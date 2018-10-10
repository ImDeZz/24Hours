namespace _24h_audio
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quitButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openedFilePathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.timeStatus = new System.Windows.Forms.Label();
            this.byteCounter = new System.Windows.Forms.Label();
            this.recButton = new System.Windows.Forms.Button();
            this.stoprecButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(702, 404);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openedFilePathTextBox
            // 
            this.openedFilePathTextBox.Location = new System.Drawing.Point(34, 364);
            this.openedFilePathTextBox.Name = "openedFilePathTextBox";
            this.openedFilePathTextBox.ReadOnly = true;
            this.openedFilePathTextBox.Size = new System.Drawing.Size(642, 20);
            this.openedFilePathTextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(702, 362);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(702, 309);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 3;
            this.playButton.TabStop = false;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // timeStatus
            // 
            this.timeStatus.AutoSize = true;
            this.timeStatus.Location = new System.Drawing.Point(31, 31);
            this.timeStatus.Name = "timeStatus";
            this.timeStatus.Size = new System.Drawing.Size(74, 13);
            this.timeStatus.TabIndex = 4;
            this.timeStatus.Text = "Elapsed Time:";
            // 
            // byteCounter
            // 
            this.byteCounter.AutoSize = true;
            this.byteCounter.Location = new System.Drawing.Point(31, 59);
            this.byteCounter.Name = "byteCounter";
            this.byteCounter.Size = new System.Drawing.Size(73, 13);
            this.byteCounter.TabIndex = 5;
            this.byteCounter.Text = "Bytes Written:";
            // 
            // recButton
            // 
            this.recButton.Location = new System.Drawing.Point(702, 262);
            this.recButton.Name = "recButton";
            this.recButton.Size = new System.Drawing.Size(75, 23);
            this.recButton.TabIndex = 6;
            this.recButton.Text = "Record";
            this.recButton.UseVisualStyleBackColor = true;
            this.recButton.Click += new System.EventHandler(this.recButton_Click);
            // 
            // stoprecButton
            // 
            this.stoprecButton.Location = new System.Drawing.Point(702, 212);
            this.stoprecButton.Name = "stoprecButton";
            this.stoprecButton.Size = new System.Drawing.Size(75, 23);
            this.stoprecButton.TabIndex = 7;
            this.stoprecButton.Text = "Stop Rec";
            this.stoprecButton.UseVisualStyleBackColor = true;
            this.stoprecButton.Click += new System.EventHandler(this.stoprecButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stoprecButton);
            this.Controls.Add(this.recButton);
            this.Controls.Add(this.byteCounter);
            this.Controls.Add(this.timeStatus);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.openedFilePathTextBox);
            this.Controls.Add(this.quitButton);
            this.Name = "Form1";
            this.Text = "Audio App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox openedFilePathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label timeStatus;
        private System.Windows.Forms.Label byteCounter;
        private System.Windows.Forms.Button recButton;
        private System.Windows.Forms.Button stoprecButton;
    }
}

