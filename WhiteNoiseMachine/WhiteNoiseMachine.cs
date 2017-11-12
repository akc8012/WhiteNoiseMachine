using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteNoiseMachine
{
	class WhiteNoiseMachine
	{
		private DateTime fadeInTime;
		public DateTime GetFadeInTime { get { return fadeInTime; } }

		public string GetCurrentTimeText()
		{
			return DateTime.Now.ToShortTimeString();
		}

		public string GetNoiseStartTimeText()
		{
			TimeSpan timeSpan = fadeInTime.Subtract(DateTime.Now);
			return Math.Round(timeSpan.TotalHours, 2).ToString() + " hours";
		}

		public string GetFadeInTimeText()
		{
			return GetCurrentTimeText();
		}

		public string GetFadeOutTimeText()
		{
			return GetCurrentTimeText();
		}

		bool IsTimeText(string timeText)
		{
			return Regex.Match(timeText, "\\d\\d{0,1}[:. ]\\d{2}\\s?[ap]m", RegexOptions.IgnoreCase).Value == timeText;
		}

		int ConvertHourTo24(int hour, bool isPM)
		{
			// From 1:00 PM to 11:59 PM you add 12 hours, and from 12:00 AM (midnight) to 12:59 AM you subtract 12 hours.
			if (isPM)
			{
				if (hour <= 11)
					hour += 12;
			}
			else if (hour == 12)
				hour -= 12;

			return hour;
		}

		private DateTime GetDateTimeFromInput(string input)
		{
			string errorMessage = "Please enter a valid time. Your input should look something like this: " + GetCurrentTimeText();

			if (string.IsNullOrWhiteSpace(input) || !IsTimeText(input))
				throw new Exception(errorMessage);

			int hour = Convert.ToInt32(Regex.Match(input, "\\d\\d{0,1}(?=[:. ]\\d)").Value);
			int minute = Convert.ToInt32(Regex.Match(input, "(?<=\\d[:. ])\\d{2}").Value);
			bool isPM = Regex.Match(input, "[ap]m", RegexOptions.IgnoreCase).Value.ToLower() == "pm";

			if (hour > 12 || minute > 59)
				throw new Exception(errorMessage);

			DateTime now = DateTime.Now;
			return new DateTime(now.Year, now.Month, now.AddDays(1).Day, ConvertHourTo24(hour, isPM), minute, 00);
		}

		public void SetFadeInTimeFromInput(string input)
		{
			fadeInTime = GetDateTimeFromInput(input);

			AudioPlayer.SetWhiteNoiseSound(@"D:\Documents\catRun.wav");
			AudioPlayer.PlayWhiteNoise();
		}
	}
}
