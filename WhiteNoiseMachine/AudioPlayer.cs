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
		private IWaveSource whiteNoiseSound;
		private ISoundOut soundOut;
		private readonly string SoundNotLoadedMessage = "White noise sound is not loaded.";

		public AudioPlayer(string filename)
		{
			whiteNoiseSound = CodecFactory.Instance.GetCodec(filename);
			whiteNoiseSound = whiteNoiseSound.Loop();

			soundOut = GetSoundOut();
			soundOut.Initialize(whiteNoiseSound);
		}

		public void PlayWhiteNoise()
		{
			if (soundOut == null)
				throw new Exception(SoundNotLoadedMessage);

			soundOut.Play();
		}

		public void StopWhiteNoise()
		{
			if (soundOut != null)
				soundOut.Stop();
		}

		public void SetWhiteNoiseVolume(float volume)
		{
			if (soundOut == null)
				throw new Exception(SoundNotLoadedMessage);

			soundOut.Volume = volume;
		}

		public bool WhiteNoisePlaying()
		{
			if (soundOut == null)
				return false;

			return soundOut.PlaybackState == PlaybackState.Playing;
		}

		private ISoundOut GetSoundOut()
		{
			if (WasapiOut.IsSupportedOnCurrentPlatform)
				return new WasapiOut();
			else
				return new DirectSoundOut();
		}
	}
}
