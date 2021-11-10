
namespace Filling
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.triangulationTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.k_dTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.k_sTrackBar = new System.Windows.Forms.TrackBar();
            this.mTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.triangulationLabel = new System.Windows.Forms.Label();
            this.k_dLabel = new System.Windows.Forms.Label();
            this.k_sLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.lightSourceTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangulationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_dTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_sTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gray;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(884, 661);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // triangulationTrackBar
            // 
            this.triangulationTrackBar.LargeChange = 1;
            this.triangulationTrackBar.Location = new System.Drawing.Point(949, 90);
            this.triangulationTrackBar.Maximum = 6;
            this.triangulationTrackBar.Minimum = 1;
            this.triangulationTrackBar.Name = "triangulationTrackBar";
            this.triangulationTrackBar.Size = new System.Drawing.Size(261, 56);
            this.triangulationTrackBar.TabIndex = 1;
            this.triangulationTrackBar.Value = 2;
            this.triangulationTrackBar.Scroll += new System.EventHandler(this.triangulationTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(949, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Triangulation depth =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(949, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "K_d = ";
            // 
            // k_dTrackBar
            // 
            this.k_dTrackBar.Location = new System.Drawing.Point(949, 163);
            this.k_dTrackBar.Maximum = 100;
            this.k_dTrackBar.Name = "k_dTrackBar";
            this.k_dTrackBar.Size = new System.Drawing.Size(261, 56);
            this.k_dTrackBar.TabIndex = 4;
            this.k_dTrackBar.Scroll += new System.EventHandler(this.k_dTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(949, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "K_s = ";
            // 
            // k_sTrackBar
            // 
            this.k_sTrackBar.Location = new System.Drawing.Point(949, 245);
            this.k_sTrackBar.Maximum = 100;
            this.k_sTrackBar.Name = "k_sTrackBar";
            this.k_sTrackBar.Size = new System.Drawing.Size(261, 56);
            this.k_sTrackBar.TabIndex = 6;
            this.k_sTrackBar.Value = 80;
            this.k_sTrackBar.Scroll += new System.EventHandler(this.k_sTrackBar_Scroll);
            // 
            // mTrackBar
            // 
            this.mTrackBar.Location = new System.Drawing.Point(949, 322);
            this.mTrackBar.Maximum = 100;
            this.mTrackBar.Minimum = 1;
            this.mTrackBar.Name = "mTrackBar";
            this.mTrackBar.Size = new System.Drawing.Size(261, 56);
            this.mTrackBar.TabIndex = 7;
            this.mTrackBar.Value = 1;
            this.mTrackBar.Scroll += new System.EventHandler(this.mTrackBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(952, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "M = ";
            // 
            // triangulationLabel
            // 
            this.triangulationLabel.AutoSize = true;
            this.triangulationLabel.Location = new System.Drawing.Point(1108, 67);
            this.triangulationLabel.Name = "triangulationLabel";
            this.triangulationLabel.Size = new System.Drawing.Size(17, 20);
            this.triangulationLabel.TabIndex = 9;
            this.triangulationLabel.Text = "a";
            // 
            // k_dLabel
            // 
            this.k_dLabel.AutoSize = true;
            this.k_dLabel.Location = new System.Drawing.Point(1006, 140);
            this.k_dLabel.Name = "k_dLabel";
            this.k_dLabel.Size = new System.Drawing.Size(17, 20);
            this.k_dLabel.TabIndex = 10;
            this.k_dLabel.Text = "a";
            // 
            // k_sLabel
            // 
            this.k_sLabel.AutoSize = true;
            this.k_sLabel.Location = new System.Drawing.Point(1003, 222);
            this.k_sLabel.Name = "k_sLabel";
            this.k_sLabel.Size = new System.Drawing.Size(17, 20);
            this.k_sLabel.TabIndex = 11;
            this.k_sLabel.Text = "a";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(998, 299);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(17, 20);
            this.mLabel.TabIndex = 12;
            this.mLabel.Text = "a";
            // 
            // lightSourceTimer
            // 
            this.lightSourceTimer.Enabled = true;
            this.lightSourceTimer.Interval = 1000;
            this.lightSourceTimer.Tick += new System.EventHandler(this.lightSourceTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 686);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.k_sLabel);
            this.Controls.Add(this.k_dLabel);
            this.Controls.Add(this.triangulationLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mTrackBar);
            this.Controls.Add(this.k_sTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.k_dTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.triangulationTrackBar);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Save bitmap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangulationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_dTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_sTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar triangulationTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar k_dTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar k_sTrackBar;
        private System.Windows.Forms.TrackBar mTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label triangulationLabel;
        private System.Windows.Forms.Label k_dLabel;
        private System.Windows.Forms.Label k_sLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Timer lightSourceTimer;
    }
}

