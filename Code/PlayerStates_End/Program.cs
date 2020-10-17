using PlayerStates_End.Logic;

namespace PlayerStates_End
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoPlayer player = new VideoPlayer();
            player.PlayVideo("video.mp4");
            player.TogglePlayPause();
        }
    }
}
