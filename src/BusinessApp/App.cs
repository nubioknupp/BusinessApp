using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BusinessApp
{
    public class App : Application
    {
        public App()
        {
            var navigationPage = new NavigationPage(new HomePage());
            // The root page of your application
            //navigationPage.BarBackgroundColor
            //NavigationPage.SetHasNavigationBar(this, false);
            MainPage = navigationPage;

            // The root page of your application
            //var label = new Label
            //{
            //    Text = "Customizing Xamarin Forms",
            //    XAlign = TextAlignment.Center
            //};

            //var stack = new StackLayout();
            //stack.Children.Add(label);
            //stack.VerticalOptions = LayoutOptions.Center;
            //stack.Padding = new Thickness(10);

            //var page = new ContentPage
            //{
            //    Content = stack
            //};

            //Device.OnPlatform(
            //    iOS: () =>
            //    {
            //        page.BackgroundImage = "back.png";
            //        label.FontFamily = "HelveticaNeue-Thin";
            //        label.FontSize = 20;
            //    },
            //    Android: () =>
            //    {
            //        page.BackgroundColor = Color.FromHex("#FFFFFF");
            //        label.FontFamily = "sans-serif-condensed";
            //        label.FontSize = Device.GetNamedSize(NamedSize.Medium, label);
            //    }
            //);

            //MainPage = page;
        }
    }
}
