using Piggy.Pages;

namespace Piggy
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new SplashScreen());
        }
    }
}