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
            ((System.ComponentModel.ISupportInitialize)(this.audioTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // urlSource
            // 
            this.urlSource.Location = new System.Drawing.Point(13, 80);
            this.urlSource.Name = "urlSource";
            this.urlSource.Size = new System.Drawing.Size(310, 20);
            this.urlSource.TabIndex = 0;
            // 
            // audioTrackBar
            // 
            this.audioTrackBar.Location = new System.Drawing.Point(12, 167);
            this.audioTrackBar.Name = "audioTrackBar";
            this.audioTrackBar.Size = new System.Drawing.Size(311, 45);
            this.audioTrackBar.TabIndex = 1;
            // 
            // btnGrab
            // 
            this.btnGrab.Location = new System.Drawing.Point(329, 80);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(95, 23);
            this.btnGrab.TabIndex = 2;
            this.btnGrab.Text = "Grab";
            this.btnGrab.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(329, 167);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(95, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Grabber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(430, 306);
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
    }
}

