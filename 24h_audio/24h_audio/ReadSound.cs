using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;


namespace _24h_audio
{
    class ReadSound
    {

        public WaveIn readWave = null;
        public WaveFileWriter createNewFile = null;
        public List<byte[]> data = new List<byte[]>();
        public System.IO.StreamWriter file = new System.IO.StreamWriter("WriteLines2.txt");
        public NAudio.CoreAudioApi.MMDeviceEnumerator device = new NAudio.CoreAudioApi.MMDeviceEnumerator();
        public int count = 0;
        public System.Diagnostics.Stopwatch clock = new System.Diagnostics.Stopwatch();


        public ReadSound()
        {

        }

        public void Decode()
        {
            readWave = new WaveIn();
            readWave.WaveFormat = new WaveFormat(44100, 1);
            
            readWave.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
            readWave.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);

            createNewFile = new WaveFileWriter("Test0001.wav", readWave.WaveFormat);
            

            readWave.StartRecording();
            clock.Start();
        }

        void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (clock.ElapsedMilliseconds > 101)
            {
                if (createNewFile != null)
                {
                    createNewFile.Write(e.Buffer, 0, e.BytesRecorded);
                    createNewFile.Flush();
                    float number = (device.GetDefaultAudioEndpoint(NAudio.CoreAudioApi.DataFlow.Capture, NAudio.CoreAudioApi.Role.Multimedia).AudioMeterInformation.MasterPeakValue * 1000000);

                    this.data.Add(e.Buffer);
                    if (number > 990000)
                    {
                        count++;
                        Console.WriteLine(count);
                    }
                }
                clock.Reset();
                clock.Start();
            }
            
        }

        public void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (readWave != null)
            {
                readWave.Dispose();
                readWave = null;
            }

            if (createNewFile != null)
            {
                createNewFile.Dispose();
                createNewFile = null;
            }            
        }

        internal void StopRecording()
        {
            readWave.StopRecording();
            file.Close();
        }
    }
}
