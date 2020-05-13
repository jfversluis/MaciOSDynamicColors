using System.ComponentModel;
using Xamarin.Forms;

namespace MaciOSDynamicColors
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage_iOS : ContentPage
    {
        readonly string[] colors = new[] {
            NamedPlatformColor.SystemBlue,
            NamedPlatformColor.SystemGreen,
            NamedPlatformColor.SystemIndigo,
            NamedPlatformColor.SystemPink,
            NamedPlatformColor.SystemPurple,
            NamedPlatformColor.SystemRed,
            NamedPlatformColor.SystemTeal,
            NamedPlatformColor.SystemYellow,
            NamedPlatformColor.SystemGray,
            NamedPlatformColor.SystemGray2,
            NamedPlatformColor.SystemGray3,
            NamedPlatformColor.SystemGray4,
            NamedPlatformColor.SystemGray5,
            NamedPlatformColor.SystemGray6,
            NamedPlatformColor.Label,
            NamedPlatformColor.SecondaryLabel,
            NamedPlatformColor.TertiaryLabel,
            NamedPlatformColor.QuaternaryLabel,
            NamedPlatformColor.PlaceholderText,
            NamedPlatformColor.Separator,
            NamedPlatformColor.OpaqueSeparator,
            NamedPlatformColor.Link
        };

        public MainPage_iOS()
        {
            InitializeComponent();

            Helpers.BuildColors(MyStackLayout, colors);

            Application.Current.RequestedThemeChanged += (s, a) => {
                Helpers.BuildColors(MyStackLayout, colors);
            };
        }
    }
}