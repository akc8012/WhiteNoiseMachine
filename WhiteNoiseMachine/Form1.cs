using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhiteNoiseMachine
{
	public partial class Form1 : Form
	{
		private WhiteNoiseMachine whiteNoiseMachine;

		public Form1()
		{
			InitializeComponent();
			StartMachine();
		}

		private void StartMachine()
		{
			whiteNoiseMachine = new WhiteNoiseMachine();
			whiteNoiseMachine.SetFadeInTimeFromInput(fadeInTextLabel.Text);

			UpdateTimeDisplays();

			fadeInTextLabel.Location = fadeInTextField.Location;
		}

		private void mainTimer_Tick(object sender, EventArgs e)
		{
			UpdateTimeDisplays();
			whiteNoiseMachine.UpdateWhiteNoise();

			if (whiteNoiseMachine.GetVolume > 0.0f)
				stopNoiseButton.Enabled = true;
		}

		private void UpdateTimeDisplays()
		{
			timeLabel.Text = whiteNoiseMachine.GetCurrentTimeText();
			noiseStartTimeLabel.Text = whiteNoiseMachine.GetNoiseStartTimeText();

			fadeInVolumeLabel.Text = whiteNoiseMachine.GetFadeInVolumeText();
		}

		// todo: separate between events and helper methods

		private void fadeInTextLabel_Click(object sender, EventArgs e)
		{
			fadeInTextLabel.Visible = false;

			fadeInTextField.Text = fadeInTextLabel.Text;
			fadeInTextField.Visible = true;
			fadeInTextField.Enabled = true;
			fadeInTextField.Focus();

			whiteNoiseMachine.StartNoise();
		}

		private void fadeInTextField_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				try
				{
					whiteNoiseMachine.SetFadeInTimeFromInput(fadeInTextField.Text);
					Console.WriteLine(whiteNoiseMachine.GetFadeInTime);

					fadeInTextLabel.Text = whiteNoiseMachine.GetFadeInTime.ToShortTimeString();

					fadeInTextField.Visible = false;
					fadeInTextField.Enabled = false;
					fadeInTextLabel.Visible = true;

					UpdateTimeDisplays();
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				whiteNoiseMachine.StopNoise();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void stopNoiseButton_Click(object sender, EventArgs e)
		{
			whiteNoiseMachine.StopNoise();
			stopNoiseButton.Enabled = false;

			UpdateTimeDisplays();
		}
	}
}
