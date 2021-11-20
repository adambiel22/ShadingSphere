using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

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
            kTrackBar.Value = (int)(appManager.K * kTrackBar.Maximum);
            kLabel.Text = appManager.K.ToString();

            triangulationCheckBox.Checked = appManager.IsGrid;
            triangulationTrackBar.Value = appManager.TriangulationLevel;
            triangulationLabel.Text = appManager.TriangulationLevel.ToString();
            k_dTrackBar.Value = (int)(appManager.Kd * k_dTrackBar.Maximum);
            k_dLabel.Text = appManager.Kd.ToString();
            k_sTrackBar.Value = (int)(appManager.Ks * k_sTrackBar.Maximum);
            k_sLabel.Text = appManager.Ks.ToString();
            mTrackBar.Value = appManager.M;
            mLabel.Text = appManager.M.ToString();

            lightColorButton.BackColor = appManager.LightColor;
            heightTrackBar.Value = appManager.Height;
            heightLabel.Text = appManager.Height.ToString();
            animationCheckBox.Checked = appManager.IsAnimation;

            appManager.Paint();
        }

        private void k_dTrackBar_Scroll(object sender, EventArgs e)
        {
            appManager.Kd = (double)k_dTrackBar.Value / k_dTrackBar.Maximum;
            k_dLabel.Text = ((double)k_dTrackBar.Value / k_dTrackBar.Maximum).ToString();
        }

        private void triangulationTrackBar_Scroll(object sender, EventArgs e)
        {
            appManager.TriangulationLevel = triangulationTrackBar.Value;
            triangulationLabel.Text = triangulationTrackBar.Value.ToString();
        }

        private void k_sTrackBar_Scroll(object sender, EventArgs e)
        {
            appManager.Ks = (double)k_sTrackBar.Value / k_sTrackBar.Maximum;
            k_sLabel.Text = ((double)k_sTrackBar.Value / k_sTrackBar.Maximum).ToString();
        }

        private void mTrackBar_Scroll(object sender, EventArgs e)
        {
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
                appManager.SetObjectBackgroundImage(new Bitmap(openFileDialog.FileName));
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

        private void kTrackBar_Scroll(object sender, EventArgs e)
        {
            appManager.K = (double)kTrackBar.Value / kTrackBar.Maximum;
            kLabel.Text = appManager.K.ToString();
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

        private void normalMapImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                appManager.SetNormalMap(new Bitmap(openFileDialog.FileName));
            }
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Debug.WriteLine(e.Location);
        }
    }
}
