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
	}
}
