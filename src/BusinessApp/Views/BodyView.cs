using Xamarin.Forms;

namespace BusinessApp.Views
{
    public class BodyView : ContentView
    {
        public BodyView()
        {
            var stack = new StackLayout {Padding = new Thickness(20, 0, 20, 0)};

            var summary = new Label
            {
                Text = "Software Engineer",
                FontSize = 14,
                FontFamily = Device.OnPlatform("HelveticaNeue", "sans-serif", "Segoe UI"),
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Start,
                TextColor = Color.Black,
                HeightRequest = 70
            };

            //var line = new BoxView
            //{
            //    Color = Color.FromHex("#FFF3F3F3"),
            //    WidthRequest = 100,
            //    HeightRequest = 2
            //};

            //stack.Children.Add(line);

            stack.Children.Add(summary);

            stack.Children.Add(new SocialMediaView());

            Content = stack;
        }
    }
}
