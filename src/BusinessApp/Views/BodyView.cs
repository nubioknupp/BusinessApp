using BusinessApp.Model;
using Xamarin.Forms;

namespace BusinessApp.Views
{
    public class BodyView : ContentView
    {
        public BodyView(Profile profile)
        {
            var stack = new StackLayout {Padding = new Thickness(20, 0, 20, 0)};

            var summary = new Label
            {
                Text = profile.Summary,
                FontSize = 14,
                FontFamily = Device.OnPlatform("HelveticaNeue", "sans-serif", "Segoe UI"),
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Start,
                TextColor = Color.Black,
                HeightRequest = 70
            };

            stack.Children.Add(summary);

            stack.Children.Add(new SocialMediaView());

            Content = stack;
        }
    }
}
