using AppKit;
using MaciOSDynamicColors.MacOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

[assembly: Dependency(typeof(PlatformColorProvider))]
namespace MaciOSDynamicColors.MacOS
{
    public class PlatformColorProvider : IPlatformColorService
    {
        public Color GetNamedColor(string name)
        {
            NSColor resultColor;
            switch (name)
            {
                case "SystemBlueColor":
                    resultColor = NSColor.SystemBlueColor;
                    break;
                case "SystemBrownColor":
                    resultColor = NSColor.SystemBrownColor;
                    break;
                case "SystemGrayColor":
                    resultColor = NSColor.SystemGrayColor;
                    break;
                case "SystemGreenColor":
                    resultColor = NSColor.SystemGreenColor;
                    break;
                case "SystemIndigoColor":
                    resultColor = NSColor.SystemIndigoColor;
                    break;
                case "SystemOrangeColor":
                    resultColor = NSColor.SystemOrangeColor;
                    break;
                case "SystemPinkColor":
                    resultColor = NSColor.SystemPinkColor;
                    break;
                case "SystemPurpleColor":
                    resultColor = NSColor.SystemPurpleColor;
                    break;
                case "SystemRedColor":
                    resultColor = NSColor.SystemRedColor;
                    break;
                case "SystemTealColor":
                    resultColor = NSColor.SystemTealColor;
                    break;
                case "SystemYellowColor":
                    resultColor = NSColor.SystemYellowColor;
                    break;
                case "AlternateSelectedControl":
                    resultColor = NSColor.AlternateSelectedControl;
                    break;
                case "AlternateSelectedControlText":
                    resultColor = NSColor.AlternateSelectedControlText;
                    break;
                case "ControlBackground":
                    resultColor = NSColor.ControlBackground;
                    break;
                case "ControlText":
                    resultColor = NSColor.ControlText;
                    break;
                case "DisabledControlText":
                    resultColor = NSColor.DisabledControlText;
                    break;
                case "Grid":
                    resultColor = NSColor.Grid;
                    break;
                case "HeaderText":
                    resultColor = NSColor.HeaderText;
                    break;
                case "Highlight":
                    resultColor = NSColor.Highlight;
                    break;
                case "LabelColor":
                    resultColor = NSColor.LabelColor;
                    break;
                case "LinkColor":
                    resultColor = NSColor.LinkColor;
                    break;
                case "PlaceholderTextColor":
                    resultColor = NSColor.PlaceholderTextColor;
                    break;
                case "QuaternaryLabelColor":
                    resultColor = NSColor.QuaternaryLabelColor;
                    break;
                case "TertiaryLabelColor":
                    resultColor = NSColor.TertiaryLabelColor;
                    break;
                case "SecondaryLabelColor":
                    resultColor = NSColor.SecondaryLabelColor;
                    break;
                case "SecondarySelectedControl":
                    resultColor = NSColor.SecondarySelectedControl;
                    break;
                case "SelectedContentBackgroundColor":
                    resultColor = NSColor.SelectedContentBackgroundColor;
                    break;
                case "SelectedControl":
                    resultColor = NSColor.SelectedControl;
                    break;
                case "SelectedControlText":
                    resultColor = NSColor.SelectedControlText;
                    break;
                case "SelectedMenuItemText":
                    resultColor = NSColor.SelectedMenuItemText;
                    break;
                case "SelectedText":
                    resultColor = NSColor.SelectedText;
                    break;
                case "SelectedTextBackground":
                    resultColor = NSColor.SelectedTextBackground;
                    break;
                case "SeparatorColor":
                    resultColor = NSColor.SeparatorColor;
                    break;
                case "Shadow":
                    resultColor = NSColor.Shadow;
                    break;
                case "Text":
                    resultColor = NSColor.Text;
                    break;
                case "TextBackground":
                    resultColor = NSColor.TextBackground;
                    break;
                case "UnderPageBackgroundColor":
                    resultColor = NSColor.UnderPageBackgroundColor;
                    break;
                case "UnemphasizedSelectedContentBackgroundColor":
                    resultColor = NSColor.UnemphasizedSelectedContentBackgroundColor;
                    break;
                case "UnemphasizedSelectedTextBackgroundColor":
                    resultColor = NSColor.UnemphasizedSelectedTextBackgroundColor;
                    break;
                case "UnemphasizedSelectedTextColor":
                    resultColor = NSColor.UnemphasizedSelectedTextColor;
                    break;
                case "WindowBackground":
                    resultColor = NSColor.WindowBackground;
                    break;
                case "WindowFrameText":
                    resultColor = NSColor.WindowFrameText;
                    break;
                default:
                    resultColor = NSColor.Black;
                    break;
            }

            return resultColor.ToColor(NSColorSpace.DeviceRGBColorSpace);
        }
    }
}