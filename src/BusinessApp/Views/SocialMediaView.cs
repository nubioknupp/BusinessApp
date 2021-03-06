using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace BusinessApp.Views
{
    public class SocialMediaView : ContentView
    {
        public SocialMediaView()
        {
            var stack = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal,
                Padding = new Thickness(0, 15, 0,0)
            };

            var facebook = new Image
            {
                Source = new FileImageSource {File = "facebook.png" },
                WidthRequest = 32,
                HeightRequest = 32
            };

            var github = new Image
            {
                Source = new FileImageSource { File = "github.png" },
                BackgroundColor = Color.FromHex("#FFF3F3F3"),
                WidthRequest = 32,
                HeightRequest = 32
            };

            var twitter = new Image
            {
                Source = new FileImageSource { File = "twitter.png" },
                WidthRequest = 32,
                HeightRequest = 32
            };

            stack.Children.Add(facebook);
            stack.Children.Add(github);
            stack.Children.Add(twitter);

            Content = stack;
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             