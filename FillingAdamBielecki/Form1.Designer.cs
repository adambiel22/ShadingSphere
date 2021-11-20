
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.triangulationTrackBar = new System.Windows.Forms.TrackBar();
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
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundFromImageButton = new System.Windows.Forms.Button();
            this.plainColorButton = new System.Windows.Forms.Button();
            this.interpolationCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundFromImageRadioButton = new System.Windows.Forms.RadioButton();
            this.plainColorRadioButton = new System.Windows.Forms.RadioButton();
            this.lightColorButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kLabel = new System.Windows.Forms.Label();
            this.kTrackBar = new System.Windows.Forms.TrackBar();
            this.normalMapImageButton = new System.Windows.Forms.Button();
            this.normalMapFromImageRadioButton = new System.Windows.Forms.RadioButton();
            this.withoutRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.triangulationCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.realFPSLabel = new System.Windows.Forms.Label();
            this.velocityLabel = new System.Windows.Forms.Label();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.animationCheckBox = new System.Windows.Forms.CheckBox();
            this.heightTrackBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.fpsTrackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.velocityTrackBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangulationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_dTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_sTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kTrackBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gray;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(860, 948);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // triangulationTrackBar
            // 
            this.triangulationTrackBar.LargeChange = 1;
            this.triangulationTrackBar.Location = new System.Drawing.Point(6, 56);
            this.triangulationTrackBar.Maximum = 6;
            this.triangulationTrackBar.Minimum = 1;
            this.triangulationTrackBar.Name = "triangulationTrackBar";
            this.triangulationTrackBar.Size = new System.Drawing.Size(239, 56);
            this.triangulationTrackBar.TabIndex = 1;
            this.triangulationTrackBar.Value = 2;
            this.triangulationTrackBar.Scroll += new System.EventHandler(this.triangulationTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kd";
            // 
            // k_dTrackBar
            // 
            this.k_dTrackBar.Location = new System.Drawing.Point(6, 115);
            this.k_dTrackBar.Maximum = 100;
            this.k_dTrackBar.Name = "k_dTrackBar";
            this.k_dTrackBar.Size = new System.Drawing.Size(239, 56);
            this.k_dTrackBar.TabIndex = 4;
            this.k_dTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.k_dTrackBar.Scroll += new System.EventHandler(this.k_dTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ks";
            // 
            // k_sTrackBar
            // 
            this.k_sTrackBar.Location = new System.Drawing.Point(6, 177);
            this.k_sTrackBar.Maximum = 100;
            this.k_sTrackBar.Name = "k_sTrackBar";
            this.k_sTrackBar.Size = new System.Drawing.Size(239, 56);
            this.k_sTrackBar.TabIndex = 6;
            this.k_sTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.k_sTrackBar.Value = 80;
            this.k_sTrackBar.Scroll += new System.EventHandler(this.k_sTrackBar_Scroll);
            // 
            // mTrackBar
            // 
            this.mTrackBar.Location = new System.Drawing.Point(6, 239);
            this.mTrackBar.Maximum = 100;
            this.mTrackBar.Minimum = 1;
            this.mTrackBar.Name = "mTrackBar";
            this.mTrackBar.Size = new System.Drawing.Size(239, 56);
            this.mTrackBar.TabIndex = 7;
            this.mTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mTrackBar.Value = 1;
            this.mTrackBar.Scroll += new System.EventHandler(this.mTrackBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "M";
            // 
            // triangulationLabel
            // 
            this.triangulationLabel.AutoSize = true;
            this.triangulationLabel.Location = new System.Drawing.Point(245, 56);
            this.triangulationLabel.Name = "triangulationLabel";
            this.triangulationLabel.Size = new System.Drawing.Size(17, 20);
            this.triangulationLabel.TabIndex = 9;
            this.triangulationLabel.Text = "a";
            // 
            // k_dLabel
            // 
            this.k_dLabel.AutoSize = true;
            this.k_dLabel.Location = new System.Drawing.Point(245, 115);
            this.k_dLabel.Name = "k_dLabel";
            this.k_dLabel.Size = new System.Drawing.Size(17, 20);
            this.k_dLabel.TabIndex = 10;
            this.k_dLabel.Text = "a";
            // 
            // k_sLabel
            // 
            this.k_sLabel.AutoSize = true;
            this.k_sLabel.Location = new System.Drawing.Point(244, 177);
            this.k_sLabel.Name = "k_sLabel";
            this.k_sLabel.Size = new System.Drawing.Size(17, 20);
            this.k_sLabel.TabIndex = 11;
            this.k_sLabel.Text = "a";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(244, 239);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(17, 20);
            this.mLabel.TabIndex = 12;
            this.mLabel.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Light color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backgroundFromImageButton);
            this.groupBox1.Controls.Add(this.plainColorButton);
            this.groupBox1.Controls.Add(this.interpolationCheckBox);
            this.groupBox1.Controls.Add(this.backgroundFromImageRadioButton);
            this.groupBox1.Controls.Add(this.plainColorRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(924, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 154);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object background";
            // 
            // backgroundFromImageButton
            // 
            this.backgroundFromImageButton.Location = new System.Drawing.Point(145, 73);
            this.backgroundFromImageButton.Name = "backgroundFromImageButton";
            this.backgroundFromImageButton.Size = new System.Drawing.Size(94, 29);
            this.backgroundFromImageButton.TabIndex = 16;
            this.backgroundFromImageButton.Text = "Select";
            this.backgroundFromImageButton.UseVisualStyleBackColor = true;
            this.backgroundFromImageButton.Click += new System.EventHandler(this.backgroundFromImageButton_Click);
            // 
            // plainColorButton
            // 
            this.plainColorButton.BackColor = System.Drawing.Color.White;
            this.plainColorButton.Location = new System.Drawing.Point(145, 34);
            this.plainColorButton.Name = "plainColorButton";
            this.plainColorButton.Size = new System.Drawing.Size(94, 29);
            this.plainColorButton.TabIndex = 15;
            this.plainColorButton.UseVisualStyleBackColor = false;
            this.plainColorButton.Click += new System.EventHandler(this.plainColorButton_Click);
            // 
            // interpolationCheckBox
            // 
            this.interpolationCheckBox.AutoSize = true;
            this.interpolationCheckBox.Location = new System.Drawing.Point(6, 115);
            this.interpolationCheckBox.Name = "interpolationCheckBox";
            this.interpolationCheckBox.Size = new System.Drawing.Size(117, 24);
            this.interpolationCheckBox.TabIndex = 2;
            this.interpolationCheckBox.Text = "Interpolation";
            this.interpolationCheckBox.UseVisualStyleBackColor = true;
            this.interpolationCheckBox.CheckedChanged += new System.EventHandler(this.interpolationCheckBox_CheckedChanged);
            // 
            // backgroundFromImageRadioButton
            // 
            this.backgroundFromImageRadioButton.AutoSize = true;
            this.backgroundFromImageRadioButton.Location = new System.Drawing.Point(6, 75);
            this.backgroundFromImageRadioButton.Name = "backgroundFromImageRadioButton";
            this.backgroundFromImageRadioButton.Size = new System.Drawing.Size(110, 24);
            this.backgroundFromImageRadioButton.TabIndex = 1;
            this.backgroundFromImageRadioButton.TabStop = true;
            this.backgroundFromImageRadioButton.Text = "From image";
            this.backgroundFromImageRadioButton.UseVisualStyleBackColor = true;
            this.backgroundFromImageRadioButton.CheckedChanged += new System.EventHandler(this.backgroundFromImageRadioButton_CheckedChanged);
            // 
            // plainColorRadioButton
            // 
            this.plainColorRadioButton.AutoSize = true;
            this.plainColorRadioButton.Location = new System.Drawing.Point(6, 38);
            this.plainColorRadioButton.Name = "plainColorRadioButton";
            this.plainColorRadioButton.Size = new System.Drawing.Size(100, 24);
            this.plainColorRadioButton.TabIndex = 0;
            this.plainColorRadioButton.TabStop = true;
            this.plainColorRadioButton.Text = "Plain color";
            this.plainColorRadioButton.UseVisualStyleBackColor = true;
            this.plainColorRadioButton.CheckedChanged += new System.EventHandler(this.plainColorRadioButton_CheckedChanged);
            // 
            // lightColorButton
            // 
            this.lightColorButton.BackColor = System.Drawing.Color.White;
            this.lightColorButton.Location = new System.Drawing.Point(145, 26);
            this.lightColorButton.Name = "lightColorButton";
            this.lightColorButton.Size = new System.Drawing.Size(94, 29);
            this.lightColorButton.TabIndex = 3;
            this.lightColorButton.UseVisualStyleBackColor = false;
            this.lightColorButton.Click += new System.EventHandler(this.lightColorButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.kLabel);
            this.groupBox2.Controls.Add(this.kTrackBar);
            this.groupBox2.Controls.Add(this.normalMapImageButton);
            this.groupBox2.Controls.Add(this.normalMapFromImageRadioButton);
            this.groupBox2.Controls.Add(this.withoutRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(924, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 168);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Normal Map";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "K";
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(251, 126);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(17, 20);
            this.kLabel.TabIndex = 14;
            this.kLabel.Text = "a";
            // 
            // kTrackBar
            // 
            this.kTrackBar.LargeChange = 0;
            this.kTrackBar.Location = new System.Drawing.Point(6, 126);
            this.kTrackBar.Maximum = 100;
            this.kTrackBar.Name = "kTrackBar";
            this.kTrackBar.Size = new System.Drawing.Size(239, 56);
            this.kTrackBar.TabIndex = 14;
            this.kTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.kTrackBar.Value = 2;
            this.kTrackBar.Scroll += new System.EventHandler(this.kTrackBar_Scroll);
            // 
            // normalMapImageButton
            // 
            this.normalMapImageButton.Location = new System.Drawing.Point(145, 71);
            this.normalMapImageButton.Name = "normalMapImageButton";
            this.normalMapImageButton.Size = new System.Drawing.Size(94, 29);
            this.normalMapImageButton.TabIndex = 17;
            this.normalMapImageButton.Text = "Select";
            this.normalMapImageButton.UseVisualStyleBackColor = true;
            this.normalMapImageButton.Click += new System.EventHandler(this.normalMapImageButton_Click);
            // 
            // normalMapFromImageRadioButton
            // 
            this.normalMapFromImageRadioButton.AutoSize = true;
            this.normalMapFromImageRadioButton.Location = new System.Drawing.Point(6, 76);
            this.normalMapFromImageRadioButton.Name = "normalMapFromImageRadioButton";
            this.normalMapFromImageRadioButton.Size = new System.Drawing.Size(110, 24);
            this.normalMapFromImageRadioButton.TabIndex = 18;
            this.normalMapFromImageRadioButton.TabStop = true;
            this.normalMapFromImageRadioButton.Text = "From image";
            this.normalMapFromImageRadioButton.UseVisualStyleBackColor = true;
            this.normalMapFromImageRadioButton.CheckedChanged += new System.EventHandler(this.normalMapFromImageRadioButton_CheckedChanged);
            // 
            // withoutRadioButton
            // 
            this.withoutRadioButton.AutoSize = true;
            this.withoutRadioButton.Location = new System.Drawing.Point(6, 37);
            this.withoutRadioButton.Name = "withoutRadioButton";
            this.withoutRadioButton.Size = new System.Drawing.Size(83, 24);
            this.withoutRadioButton.TabIndex = 17;
            this.withoutRadioButton.TabStop = true;
            this.withoutRadioButton.Text = "Without";
            this.withoutRadioButton.UseVisualStyleBackColor = true;
            this.withoutRadioButton.CheckedChanged += new System.EventHandler(this.withoutRadioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.triangulationCheckBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.mTrackBar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.mLabel);
            this.groupBox3.Controls.Add(this.k_sTrackBar);
            this.groupBox3.Controls.Add(this.triangulationLabel);
            this.groupBox3.Controls.Add(this.k_dLabel);
            this.groupBox3.Controls.Add(this.k_sLabel);
            this.groupBox3.Controls.Add(this.triangulationTrackBar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.k_dTrackBar);
            this.groupBox3.Location = new System.Drawing.Point(924, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 299);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Surface";
            // 
            // triangulationCheckBox
            // 
            this.triangulationCheckBox.AutoSize = true;
            this.triangulationCheckBox.Location = new System.Drawing.Point(8, 26);
            this.triangulationCheckBox.Name = "triangulationCheckBox";
            this.triangulationCheckBox.Size = new System.Drawing.Size(118, 24);
            this.triangulationCheckBox.TabIndex = 13;
            this.triangulationCheckBox.Text = "Triangulation";
            this.triangulationCheckBox.UseVisualStyleBackColor = true;
            this.triangulationCheckBox.CheckedChanged += new System.EventHandler(this.triangulationCheckBox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.realFPSLabel);
            this.groupBox4.Controls.Add(this.velocityLabel);
            this.groupBox4.Controls.Add(this.fpsLabel);
            this.groupBox4.Controls.Add(this.animationCheckBox);
            this.groupBox4.Controls.Add(this.heightTrackBar);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.fpsTrackBar);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.heightLabel);
            this.groupBox4.Controls.Add(this.velocityTrackBar);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lightColorButton);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(924, 651);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 309);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Light Source";
            // 
            // realFPSLabel
            // 
            this.realFPSLabel.AutoSize = true;
            this.realFPSLabel.Location = new System.Drawing.Point(58, 157);
            this.realFPSLabel.Name = "realFPSLabel";
            this.realFPSLabel.Size = new System.Drawing.Size(17, 20);
            this.realFPSLabel.TabIndex = 24;
            this.realFPSLabel.Text = "0";
            // 
            // velocityLabel
            // 
            this.velocityLabel.AutoSize = true;
            this.velocityLabel.Location = new System.Drawing.Point(245, 242);
            this.velocityLabel.Name = "velocityLabel";
            this.velocityLabel.Size = new System.Drawing.Size(17, 20);
            this.velocityLabel.TabIndex = 23;
            this.velocityLabel.Text = "a";
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Location = new System.Drawing.Point(244, 180);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(17, 20);
            this.fpsLabel.TabIndex = 22;
            this.fpsLabel.Text = "a";
            // 
            // animationCheckBox
            // 
            this.animationCheckBox.AutoSize = true;
            this.animationCheckBox.Location = new System.Drawing.Point(8, 125);
            this.animationCheckBox.Name = "animationCheckBox";
            this.animationCheckBox.Size = new System.Drawing.Size(100, 24);
            this.animationCheckBox.TabIndex = 17;
            this.animationCheckBox.Text = "Animation";
            this.animationCheckBox.UseVisualStyleBackColor = true;
            this.animationCheckBox.CheckedChanged += new System.EventHandler(this.animationCheckBox_CheckedChanged);
            // 
            // heightTrackBar
            // 
            this.heightTrackBar.Location = new System.Drawing.Point(6, 86);
            this.heightTrackBar.Maximum = 1000;
            this.heightTrackBar.Minimum = 10;
            this.heightTrackBar.Name = "heightTrackBar";
            this.heightTrackBar.Size = new System.Drawing.Size(239, 56);
            this.heightTrackBar.TabIndex = 21;
            this.heightTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.heightTrackBar.Value = 500;
            this.heightTrackBar.Scroll += new System.EventHandler(this.heightTrackBar_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Velocity";
            // 
            // fpsTrackBar
            // 
            this.fpsTrackBar.Location = new System.Drawing.Point(6, 180);
            this.fpsTrackBar.Maximum = 100;
            this.fpsTrackBar.Minimum = 1;
            this.fpsTrackBar.Name = "fpsTrackBar";
            this.fpsTrackBar.Size = new System.Drawing.Size(239, 56);
            this.fpsTrackBar.TabIndex = 19;
            this.fpsTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.fpsTrackBar.Value = 10;
            this.fpsTrackBar.Scroll += new System.EventHandler(this.fpsTrackBar_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "FPS";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(244, 86);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(17, 20);
            this.heightLabel.TabIndex = 13;
            this.heightLabel.Text = "a";
            // 
            // velocityTrackBar
            // 
            this.velocityTrackBar.Location = new System.Drawing.Point(8, 242);
            this.velocityTrackBar.Maximum = 360;
            this.velocityTrackBar.Name = "velocityTrackBar";
            this.velocityTrackBar.Size = new System.Drawing.Size(239, 56);
            this.velocityTrackBar.TabIndex = 13;
            this.velocityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.velocityTrackBar.Value = 100;
            this.velocityTrackBar.Scroll += new System.EventHandler(this.velocityTrackBar_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 972);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save bitmap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangulationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_dTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_sTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kTrackBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar triangulationTrackBar;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button backgroundFromImageButton;
        private System.Windows.Forms.Button plainColorButton;
        private System.Windows.Forms.CheckBox interpolationCheckBox;
        private System.Windows.Forms.RadioButton backgroundFromImageRadioButton;
        private System.Windows.Forms.RadioButton plainColorRadioButton;
        private System.Windows.Forms.Button lightColorButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button normalMapImageButton;
        private System.Windows.Forms.RadioButton normalMapFromImageRadioButton;
        private System.Windows.Forms.RadioButton withoutRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label velocityLabel;
        private System.Windows.Forms.Label fpsLabel;
        private System.Windows.Forms.CheckBox animationCheckBox;
        private System.Windows.Forms.TrackBar heightTrackBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar fpsTrackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TrackBar velocityTrackBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox triangulationCheckBox;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.TrackBar kTrackBar;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label realFPSLabel;
    }
}

