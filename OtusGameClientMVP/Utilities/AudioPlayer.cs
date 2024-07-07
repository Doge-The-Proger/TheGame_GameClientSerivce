using Plugin.Maui.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusGameClientMVP.Utilities
{
    public class AudioPlayer
    {
        private IAudioPlayer audioPlayer;

        public async void PlayAudio(string filename)
        {
            audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(filename));

            audioPlayer.Play();
        }
    }
}
