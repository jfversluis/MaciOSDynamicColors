using Xamarin.Forms;

namespace MaciOSDynamicColors
{
    public interface IPlatformColorService
    {
        Color GetNamedColor(string name);
    }
}