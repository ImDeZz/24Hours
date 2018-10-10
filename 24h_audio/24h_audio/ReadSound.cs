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
        }

        void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (createNewFile != null)
            {
                createNewFile.Write(e.Buffer, 0, e.BytesRecorded);
                createNewFile.Flush();
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
        }
    }
}
