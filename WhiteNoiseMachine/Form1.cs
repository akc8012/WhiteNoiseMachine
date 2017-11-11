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
			UpdateTimeDisplays();
		}

		private void UpdateTimeDisplays()
		{
			timeLabel.Text = whiteNoiseMachine.GetCurrentTimeText();
		}

		private void fadeInTextField_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				TextBox textBox = sender as TextBox;
				string input = textBox.Text;

				try
				{
					DateTime dateTime = whiteNoiseMachine.GetDateTimeFromInput(input);
					Console.WriteLine(dateTime);
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
