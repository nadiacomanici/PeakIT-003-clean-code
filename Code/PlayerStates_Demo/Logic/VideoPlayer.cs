using System;
using System.IO;

namespace PlayerStates_Demo.Logic
{
    public enum VideoState
    {
        NotInitialized = 0,
        VideoLoaded = 1,
        Playing = 2,
        Pause = 3,
        Stopped = 4
    }

    public class VideoPlayer
    {
        private VideoState CurrentState = VideoState.NotInitialized;

        public void TogglePlayPause()
        {
            if (CurrentState == VideoState.VideoLoaded)
            {
                Play();
            }
            else
            {
                if (CurrentState == VideoState.Playing)
                {
                    Pause();
                }
                else
                {
                    throw new InvalidOperationException("Wrong player state");
                }
            }
        }

        private void Play()
        {
            Console.WriteLine("Play");
            CurrentState = VideoState.Playing;
        }

        private void Pause()
        {
            Console.WriteLine("Pause");
            CurrentState = VideoState.Pause;
        }

        public void PlayVideo(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName);

            if ((fileExtension == ".mp4" || fileExtension == ".avi")
                && (CurrentState != VideoState.Playing || CurrentState == VideoState.Pause))
            {
                LoadVideo(fileName);
                Play();
            }
        }

        private void LoadVideo(string fileName)
        {
            Console.WriteLine("Loading Video");
            CurrentState = VideoState.VideoLoaded;
        }
    }
}
