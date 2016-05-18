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
            var navigationPage = new NavigationPage(new HomePage())
            {
                // put your color here
                BarBackgroundColor = Color.FromHex("#FFD24545"),
                BarTextColor = Color.FromHex("#FFFFFF"),
            };

            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
