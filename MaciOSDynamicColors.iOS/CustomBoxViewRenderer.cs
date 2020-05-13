using System.ComponentModel;
using UIKit;
using MaciOSDynamicColors;
using MaciOSDynamicColors.MacOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomBoxView), typeof(CustomBoxViewRenderer))]
namespace MaciOSDynamicColors.MacOS
{
    public class CustomBoxViewRenderer : BoxRenderer
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
                        BoxView.Color = UIColor.SystemBlueColor.ToColor();
                        break;
                    case "SystemGray":
                        BoxView.Color = UIColor.SystemGrayColor.ToColor();
                        break;
                    case "SystemGreen":
                        BoxView.Color = UIColor.SystemGreenColor.ToColor();
                        break;
                    case "SystemIndigo":
                        BoxView.Color = UIColor.SystemIndigoColor.ToColor();
                        break;
                    case "SystemOrange":
                        BoxView.Color = UIColor.SystemOrangeColor.ToColor();
                        break;
                    case "SystemPink":
                        BoxView.Color = UIColor.SystemPinkColor.ToColor();
                        break;
                    case "SystemPurple":
                        BoxView.Color = UIColor.SystemPurpleColor.ToColor();
                        break;
                    case "SystemRed":
                        BoxView.Color = UIColor.SystemRedColor.ToColor();
                        break;
                    case "SystemTeal":
                        BoxView.Color = UIColor.SystemTealColor.ToColor();
                        break;
                    case "SystemYellow":
                        BoxView.Color = UIColor.SystemYellowColor.ToColor();
                        break;
                }
            }
        }
    }
}