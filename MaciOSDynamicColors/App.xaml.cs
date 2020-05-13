using Xamarin.Forms;

namespace MaciOSDynamicColors
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Device.SetFlags(new[] { "AppTheme_Experimental" });

            if (Device.RuntimePlatform == Device.macOS)
                MainPage = new MainPage_MacOS();
            else
                MainPage = new MainPage_iOS();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}