using System.ComponentModel;
using Xamarin.Forms;

namespace MaciOSDynamicColors
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage_MacOS : ContentPage
    {
        readonly string[] colors = new[] {
            "SystemBlueColor",
            "SystemBrownColor",
            "SystemGrayColor",
            "SystemGreenColor",
            "SystemIndigoColor",
            "SystemOrangeColor",
            "SystemPinkColor",
            "SystemPurpleColor",
            "SystemRedColor",
            "SystemTealColor",
            "SystemYellowColor",
            "AlternateSelectedControl",
            "AlternateSelectedControlText",
            "ControlBackground",
            "ControlText",
            "DisabledControlText",
            "Grid",
            "HeaderText",
            "Highlight",
            "LabelColor",
            "LinkColor",
            "PlaceholderTextColor",
            "QuaternaryLabelColor",
            "TertiaryLabelColor",
            "SecondaryLabelColor",
            "SelectedControl",
            "SelectedContentBackgroundColor",
            "SelectedControl",
            "SelectedControlText",
            "SelectedMenuItemText",
            "SelectedText",
            "SelectedTextBackground",
            "SeparatorColor",
            "Shadow",
            "Text",
            "TextBackground",
            "UnderPageBackgroundColor",
            "UnemphasizedSelectedContentBackgroundColor",
            "UnemphasizedSelectedTextBackgroundColor",
            "UnemphasizedSelectedTextColor",
            "WindowBackground",
            "WindowFrameText"
        };

        public MainPage_MacOS()
        {
            InitializeComponent();

            Helpers.BuildColors(MyStackLayout, colors);

            Application.Current.RequestedThemeChanged += (s, a) =>
            {
                Helpers.BuildColors(MyStackLayout, colors);
            };
        }
    }
}