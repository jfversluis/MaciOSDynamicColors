using System.ComponentModel;
using AppKit;
using MaciOSDynamicColors;
using MaciOSDynamicColors.MacOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

[assembly: ExportRenderer(typeof(CustomBoxView), typeof(CustomBoxViewRenderer))]
namespace MaciOSDynamicColors.MacOS
{
    public class CustomBoxViewRenderer : BoxViewRenderer
    {
        private CustomBoxView BoxView => Element as CustomBoxView;

        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);

            UpdateDynamicColor();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == nameof(CustomBoxView.DynamicColorName))
                UpdateDynamicColor();
        }

        private void UpdateDynamicColor()
        {
            if (string.IsNullOrWhiteSpace(BoxView?.DynamicColorName))
                BoxView.Color = Color.Black;
            else
            {
                switch (BoxView.DynamicColorName)
                {
                    case "SystemBlue":
                        BoxView.Color = NSColor.SystemBlueColor.ToColor();
                        break;
                    case "SystemBrown":
                        BoxView.Color = NSColor.SystemBrownColor.ToColor();
                        break;
                    case "SystemGray":
                        BoxView.Color = NSColor.SystemGrayColor.ToColor();
                        break;
                    case "SystemGreen":
                        BoxView.Color = NSColor.SystemGreenColor.ToColor();
                        break;
                    case "SystemIndigo":
                        BoxView.Color = NSColor.SystemIndigoColor.ToColor();
                        break;
                    case "SystemOrange":
                        BoxView.Color = NSColor.SystemOrangeColor.ToColor();
                        break;
                    case "SystemPink":
                        BoxView.Color = NSColor.SystemPinkColor.ToColor();
                        break;
                    case "SystemPurple":
                        BoxView.Color = NSColor.SystemPurpleColor.ToColor();
                        break;
                    case "SystemRed":
                        BoxView.Color = NSColor.SystemRedColor.ToColor();
                        break;
                    case "SystemTeal":
                        BoxView.Color = NSColor.SystemTealColor.ToColor();
                        break;
                    case "SystemYellow":
                        BoxView.Color = NSColor.SystemYellowColor.ToColor();
                        break;
                }
            }
        }
    }
}