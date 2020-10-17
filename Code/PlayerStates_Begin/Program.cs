using PlayerStates_Begin.Logic;

namespace PlayerStates_Begin
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
