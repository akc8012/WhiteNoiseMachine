using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore;
using CSCore.SoundOut;
using CSCore.Codecs;
using System.Threading;

namespace WhiteNoiseMachine
{
	class AudioPlayer
	{
		private static IWaveSource whiteNoiseSound;
		private static ISoundOut soundOut;

		public static void PlayWhiteNoise()
		{
			soundOut.Play();
		}

		public static void StopWhiteNoise()
		{
			soundOut.Stop();
		}

		public static void SetWhiteNoiseVolume(float volume)
		{
			soundOut.Volume = volume;
		}

		public static void SetWhiteNoiseSound(string filename)
		{
			whiteNoiseSound = CodecFactory.Instance.GetCodec(filename);
			whiteNoiseSound = whiteNoiseSound.Loop();

			soundOut = GetSoundOut();
			soundOut.Initialize(whiteNoiseSound);
		}

		private static ISoundOut GetSoundOut()
		{
			if (WasapiOut.IsSupportedOnCurrentPlatform)
				return new WasapiOut();
			else
				return new DirectSoundOut();
		}
	}
}
