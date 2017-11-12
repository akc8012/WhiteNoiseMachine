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

		// todo: we may want to rename this to "mainTimer"
		private void timeDisplayInterval_Tick(object sender, EventArgs e)
		{
			UpdateTimeDisplays();
		}

		private void StartMachine()
		{
			whiteNoiseMachine = new WhiteNoiseMachine();
			whiteNoiseMachine.SetFadeInTimeFromInput(fadeInTextLabel.Text);

			UpdateTimeDisplays();

			fadeInTextLabel.Location = fadeInTextField.Location;
		}

		private void UpdateTimeDisplays()
		{
			timeLabel.Text = whiteNoiseMachine.GetCurrentTimeText();
			noiseStartTimeLabel.Text = whiteNoiseMachine.GetNoiseStartTimeText();
		}

		// todo: separate between events and helper methods

		private void fadeInTextLabel_Click(object sender, EventArgs e)
		{
			fadeInTextLabel.Visible = false;

			fadeInTextField.Text = fadeInTextLabel.Text;
			fadeInTextField.Visible = true;
			fadeInTextField.Enabled = true;
			fadeInTextField.Focus();
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
	}
}
