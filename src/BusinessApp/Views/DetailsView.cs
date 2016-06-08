using BusinessApp.Model;
using Xamarin.Forms;

namespace BusinessApp.Views
{
    public class DetailsView : ContentView
    {
        public DetailsView(Profile profile)
        {
            var name = new Label()
            {
                Text = profile.Name,
                FontSize = 22,
                FontFamily = Device.OnPlatform("HelveticaNeue-Bold", "sans-serif-black", "Segoe UI Black"),
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black
            };

            var profession = new Label()
            {
                Text = profile.Profession,
                FontSize = 14,
                FontFamily = Device.OnPlatform("HelveticaNeue", "sans-serif", "Segoe UI"),
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black
            };

            var where = new Label()
            {
                Text = profile.Where,
                FontSize = 12,
                FontFamily = Device.OnPlatform("HelveticaNeue-Light", "sans-serif-light", "Segoe UI Light"),
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black
            };



            var stack = new StackLayout()
            {
                Padding = new Thickness(20, 10),
                Children = {
                    name,
                    profession,
                    where
                }
            };

            Content = stack;
        }
    }
}
