using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using NAudio;
using NAudio.CoreAudioApi;

namespace _24h_audio
{
    public partial class Form1 : Form
    {
        public string selectedFile;
        ReadSound readSound = new ReadSound();
        MMDevice device = null;

        public Form1()
        {
            InitializeComponent();  
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
             
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                openedFilePathTextBox.Text = openFileDialog1.FileName;
                this.selectedFile = openFileDialog1.FileName;
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Filehandler fh = new Filehandler(selectedFile);
            fh.toBytes();
            Stopwatch st = new Stopwatch();
            st.Start();
            Thread playing = new Thread(() => playingSound(st, fh));
            playing.Start();
        }

        public void playingSound(Stopwatch st, Filehandler fh)
        {
            SendSound s = new SendSound();
            while (st.ElapsedMilliseconds <= 115000)
            {
                uint[] currentByte = fh.getNextByte();

                int i = 0;
                if (currentByte != null)
                {
                    foreach (uint bit in currentByte)
                    {
                        s.createSound(bit);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void recButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            MMDeviceEnumerator microphones = new MMDeviceEnumerator();
            device = microphones.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active)[0];
            Console.WriteLine("Using " + device.ToString());
            //readSound.Decode();
        }

        private void stoprecButton_Click(object sender, EventArgs e)
        {
            readSound.StopRecording();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine((int)(device.AudioMeterInformation.MasterPeakValue*100*0.5));
        }
    }
}
