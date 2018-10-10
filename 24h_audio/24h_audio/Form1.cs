using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24h_audio
{
    public partial class Form1 : Form
    {
        public string selectedFile;

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

        }
    }
}
