using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtusGameClientMVP.Utilities;

namespace OtusGameClientMVP.GameLogic
{
    //TODO
    public class GameManager
    {
        private bool IsPlayingMusic = false;
        private MusicStoreManager MusicManager;

        public GameManager(MusicStoreManager musicManager)
        {
            MusicManager = musicManager; 
        }

        public void StartPlaying(Music music)
        {
            //AudioPlayer.PlayAudio(music.filenameMp3);
        }

        public void ChooseMusic(int id)
        {
            var music = MusicManager.GetMusic(id);
            StartPlaying(music);
        }
    }
}
