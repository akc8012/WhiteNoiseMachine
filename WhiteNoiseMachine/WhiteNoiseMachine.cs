using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteNoiseMachine
{
	class WhiteNoiseMachine
	{
		public string GetCurrentTimeText()
		{
			return DateTime.Now.ToShortTimeString();
		}

		public string GetFadeInTimeText()
		{
			return GetCurrentTimeText();
		}

		public string GetFadeOutTimeText()
		{
			return GetCurrentTimeText();
		}
	}
}
