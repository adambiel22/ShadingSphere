using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace Filling
{
    public partial class Form1 : Form
    {
        private readonly AppManager appManager;

        public Form1()
        {
            InitializeComponent();

            appManager = new AppManager(pictureBox);

            plainColorRadioButton.Checked = appManager.IsObjectPlain;
            backgroundFromImageRadioButton.Checked = !appManager.IsObjectPlain;
            plainColorButton.BackColor = appManager.ObjectBacgroundColor;
            interpolationCheckBox.Checked = appManager.IsInterpolation;

            withoutRadioButton.Checked = appManager.IsWithoutNormalMap;
            normalMapFromImageRadioButton.Checked = !appManager.IsWithoutNormalMap;

            triangulationCheckBox.Checked = appManager.IsGrid;
            triangulationTrackBar.Value = appManager.TriangulationLevel;
            triangulationLabel.Text = appManager.TriangulationLevel.ToString();
            k_dTrackBar.Value = (int)(appManager.Kd * 100);
            k_dLabel.Text = appManager.Kd.ToString();
            k_sTrackBar.Value = (int)(appManager.Ks * 100);
            k_sLabel.Text = appManager.Ks.ToString();
            mTrackBar.Value = appManager.M;
            mLabel.Text = appManager.M.ToString();

            lightColorButton.BackColor = appManager.LightColor;
            heightTrackBar.Value = appManager.Height;
            heightLabel.Text = appManager.Height.ToString();
            animationCheckBox.Checked = appManager.IsAnimation;
            fpsTrackBar.Value = appManager.FPS;
            fpsLabel.Text = appManager.FPS.ToString();
            velocityTrackBar.Value = (int)appManager.Velocity;
            velocityLabel.Text = ((int)appManager.Velocity).ToString();

            appManager.Paint();
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Debug.WriteLine(e.Location);
        }

        private void k_dTrackBar_Scroll(object sender, EventArgs e)
        {
            //surfaceSettings.K_d = (double)k_dTrackBar.Value / k_dTrackBar.Maximum;
            //k_dLabel.Text = ((double)k_dTrackBar.Value / k_dTrackBar.Maximum).ToString();
            //paintSphere();

            appManager.Kd = (double)k_dTrackBar.Value / k_dTrackBar.Maximum;
            k_dLabel.Text = ((double)k_dTrackBar.Value / k_dTrackBar.Maximum).ToString();
        }

        private void triangulationTrackBar_Scroll(object sender, EventArgs e)
        {
            //sphereTriangulation = new SphereTriangulation(triangulationTrackBar.Value, r, midPoint);
            //triangulationLabel.Text = triangulationTrackBar.Value.ToString();
            //paintSphere();

            appManager.TriangulationLevel = triangulationTrackBar.Value;
            triangulationLabel.Text = triangulationTrackBar.Value.ToString();
        }

        private void k_sTrackBar_Scroll(object sender, EventArgs e)
        {
            //surfaceSettings.K_s = (double)k_sTrackBar.Value / k_sTrackBar.Maximum;
            //k_sLabel.Text = ((double)k_sTrackBar.Value / k_sTrackBar.Maximum).ToString();
            //paintSphere();

            appManager.Ks = (double)k_sTrackBar.Value / k_sTrackBar.Maximum;
            k_sLabel.Text = ((double)k_sTrackBar.Value / k_sTrackBar.Maximum).ToString();
        }

        private void mTrackBar_Scroll(object sender, EventArgs e)
        {
            //surfaceSettings.M = mTrackBar.Value;
            //mLabel.Text = mTrackBar.Value.ToString();
            //paintSphere();

            appManager.M = mTrackBar.Value;
            mLabel.Text = mTrackBar.Value.ToString();
        }

        private void plainColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (plainColorRadioButton.Checked) appManager.IsObjectPlain = true;
        }

        private void backgroundFromImageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (backgroundFromImageRadioButton.Checked) appManager.IsObjectPlain = false;
        }

        private void plainColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                appManager.ObjectBacgroundColor = colorDialog.Color;
                plainColorButton.BackColor = colorDialog.Color;
            }
        }

        private void backgroundFromImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                appManager.ObjectBackgroundImage = new Bitmap(openFileDialog.FileName);
            }
        }

        private void interpolationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            appManager.IsInterpolation = interpolationCheckBox.Checked;
        }

        private void withoutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (withoutRadioButton.Checked) appManager.IsWithoutNormalMap = true;
        }

        private void normalMapFromImageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (normalMapFromImageRadioButton.Checked) appManager.IsWithoutNormalMap = false;
        }

        private void triangulationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            appManager.IsGrid = triangulationCheckBox.Checked;
        }

        private void lightColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                appManager.LightColor = colorDialog.Color;
                lightColorButton.BackColor = colorDialog.Color;
            }
        }

        private void heightTrackBar_Scroll(object sender, EventArgs e)
        {
            appManager.Height = heightTrackBar.Value;
            heightLabel.Text = heightTrackBar.Value.ToString();
        }

        private void animationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            appManager.IsAnimation = animationCheckBox.Checked;
        }

        private void fpsTrackBar_Scroll(object sender, EventArgs e)
        {
            appManager.FPS = fpsTrackBar.Value;
            fpsLabel.Text = fpsTrackBar.Value.ToString();
        }

        private void velocityTrackBar_Scroll(object sender, EventArgs e)
        {
            appManager.Velocity = velocityTrackBar.Value;
            velocityLabel.Text = velocityTrackBar.Value.ToString();
        }

        private void normalMapImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                appManager.NormalMap = new Bitmap(openFileDialog.FileName);
            }
        }

        private void lightSourceTimer_Tick_1(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

    }
}
