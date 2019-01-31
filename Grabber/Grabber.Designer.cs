namespace Grabber
{
    partial class Grabber
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
            this.urlSource = new System.Windows.Forms.TextBox();
            this.audioTrackBar = new System.Windows.Forms.TrackBar();
            this.btnGrab = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rdoFast = new System.Windows.Forms.RadioButton();
            this.rdoFastest = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.audioTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // urlSource
            // 
            this.urlSource.Location = new System.Drawing.Point(12, 12);
            this.urlSource.Name = "urlSource";
            this.urlSource.Size = new System.Drawing.Size(310, 20);
            this.urlSource.TabIndex = 0;
            // 
            // audioTrackBar
            // 
            this.audioTrackBar.Location = new System.Drawing.Point(11, 49);
            this.audioTrackBar.Name = "audioTrackBar";
            this.audioTrackBar.Size = new System.Drawing.Size(311, 45);
            this.audioTrackBar.TabIndex = 1;
            // 
            // btnGrab
            // 
            this.btnGrab.Location = new System.Drawing.Point(329, 10);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(95, 23);
            this.btnGrab.TabIndex = 2;
            this.btnGrab.Text = "Grab";
            this.btnGrab.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(329, 49);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(95, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSpeed
            // 
            this.btnSpeed.Location = new System.Drawing.Point(329, 100);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(95, 23);
            this.btnSpeed.TabIndex = 4;
            this.btnSpeed.Text = "Speed Read";
            this.btnSpeed.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 100);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(310, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 227);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(309, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // rdoFast
            // 
            this.rdoFast.AutoSize = true;
            this.rdoFast.Location = new System.Drawing.Point(329, 138);
            this.rdoFast.Name = "rdoFast";
            this.rdoFast.Size = new System.Drawing.Size(48, 17);
            this.rdoFast.TabIndex = 7;
            this.rdoFast.TabStop = true;
            this.rdoFast.Text = "Fast ";
            this.rdoFast.UseVisualStyleBackColor = true;
            // 
            // rdoFastest
            // 
            this.rdoFastest.AutoSize = true;
            this.rdoFastest.Location = new System.Drawing.Point(329, 162);
            this.rdoFastest.Name = "rdoFastest";
            this.rdoFastest.Size = new System.Drawing.Size(59, 17);
            this.rdoFastest.TabIndex = 8;
            this.rdoFastest.TabStop = true;
            this.rdoFastest.Text = "Fastest";
            this.rdoFastest.UseVisualStyleBackColor = true;
            // 
            // Grabber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(433, 262);
            this.Controls.Add(this.rdoFastest);
            this.Controls.Add(this.rdoFast);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSpeed);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnGrab);
            this.Controls.Add(this.audioTrackBar);
            this.Controls.Add(this.urlSource);
            this.Name = "Grabber";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grabber";
            ((System.ComponentModel.ISupportInitialize)(this.audioTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlSource;
        private System.Windows.Forms.TrackBar audioTrackBar;
        private System.Windows.Forms.Button btnGrab;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rdoFast;
        private System.Windows.Forms.RadioButton rdoFastest;
    }
}

