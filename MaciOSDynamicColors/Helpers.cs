using System;
using Xamarin.Forms;

namespace MaciOSDynamicColors
{
    public class Helpers
    {
        static readonly IPlatformColorService _platformColorService = DependencyService.Get<IPlatformColorService>();

        internal static void BuildColors(StackLayout stackLayout, string[] colors)
        {
            stackLayout.Children.Clear();

            for (var i = 0; i < colors.Length; i++)
            {
                Color color;

                if (Device.RuntimePlatform == Device.iOS)
                    color = Device.GetNamedColor(colors[i]);
                else
                    color = _platformColorService.GetNamedColor(colors[i]);

                var grid = new Grid
                {
                    ColumnDefinitions = new ColumnDefinitionCollection
                    {
                        new ColumnDefinition
                        {
                            Width = 100
                        },
                        new ColumnDefinition
                        {
                            Width = GridLength.Star
                        }
                    },
                    RowDefinitions = new RowDefinitionCollection
                    {
                        new RowDefinition
                        {
                            Height = 50
                        },
                        new RowDefinition
                        {
                            Height = 50
                        }
                        ,
                        new RowDefinition
                        {
                            Height = 50
                        }
                    }
                };

                var box = new Frame
                {
                    BackgroundColor = color,
                    HasShadow = false,
                    Margin = 10,
                    HeightRequest = 200,
                    WidthRequest = 200
                };

                grid.Children.Add(box, 0, 0);
                Grid.SetRowSpan(box, 3);

                int r, g, b;
                double a;
                r = Convert.ToInt32(color.R * 255);
                g = Convert.ToInt32(color.G * 255);
                b = Convert.ToInt32(color.B * 255);
                a = Math.Round(color.A, 1);

                Console.WriteLine($"{colors[i]} - {r},{g},{b},{a}");

                grid.Children.Add(new Label { Text = colors[i] }, 1, 0);
                grid.Children.Add(new Label { Text = color.ToHex() }, 1, 1);
                grid.Children.Add(new Label { Text = $"R{r}, G{g}, B{b}, A{a}"}, 1, 2);

                stackLayout.Children.Add(grid);
            }
        }
    }
}