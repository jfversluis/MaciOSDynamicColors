using AppKit;
using Foundation;
using MaciOSDynamicColors;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

[Register("AppDelegate")]
public class AppDelegate : FormsApplicationDelegate
{
    NSWindow window;
    public AppDelegate()
    {
        var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;

        var rect = new CoreGraphics.CGRect(200, 1000, 1024, 768);
        window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
        window.Title = "Dynamic Colors macOS";
        window.TitleVisibility = NSWindowTitleVisibility.Hidden;
    }

    public override NSWindow MainWindow
    {
        get { return window; }
    }

    public override void DidFinishLaunching(NSNotification notification)
    {
        Forms.Init();
        LoadApplication(new App());
        base.DidFinishLaunching(notification);
    }
}