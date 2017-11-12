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
		private static readonly string SoundNotLoadedMessage = "White noise sound is not loaded.";

		public static void PlayWhiteNoise()
		{
			if (soundOut == null)
				throw new Exception(SoundNotLoadedMessage);

			soundOut.Play();
		}

		public static void StopWhiteNoise()
		{
			if (soundOut != null)
				soundOut.Stop();
		}

		public static void SetWhiteNoiseVolume(float volume)
		{
			if (soundOut == null)
				throw new Exception(SoundNotLoadedMessage);

			soundOut.Volume = volume;
		}

		public static float GetWhiteNoiseVolume()
		{
			if (soundOut == null)
				return 0.0f;

			return soundOut.Volume;
		}

		public static void SetWhiteNoiseSound(string filename)
		{
			whiteNoiseSound = CodecFactory.Instance.GetCodec(filename);
			if (whiteNoiseSound == null)
				throw new Exception(string.Format("Could not load sound at path {0}. Please correct your file path.", filename));

			whiteNoiseSound = whiteNoiseSound.Loop();

			soundOut = GetSoundOut();
			soundOut.Initialize(whiteNoiseSound);
		}

		public static bool WhiteNoisePlaying()
		{
			if (soundOut == null)
				return false;

			return soundOut.PlaybackState == PlaybackState.Playing;
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
