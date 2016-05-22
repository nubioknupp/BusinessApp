using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessApp.Views;
using Xamarin.Forms;

namespace BusinessApp
{
    public class App : Application
    {
        public App()
        {
            //var navigationPage = new NavigationPage(new HomePage())
            //{
            //    // put your color here
            //    BarBackgroundColor = Color.FromHex("#FFD24545"),
            //    BarTextColor = Color.FromHex("#FFFFFF"),
            //};

            //MainPage = navigationPage;

            MainPage = new ProfilePage();
        }
    }
}
