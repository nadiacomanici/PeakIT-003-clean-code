using PlayerStates_Demo.Logic;

namespace PlayerStates_Demo
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
