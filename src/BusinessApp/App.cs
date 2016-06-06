using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessApp.Dao;
using BusinessApp.Views;
using Xamarin.Forms;

namespace BusinessApp
{
    public class App : Application
    {
        public App()
        {
            //var navigationPage = new NavigationPage(new ProfilePage())
            //{
            //    // put your color here
            //    BarBackgroundColor = Color.FromHex("#FFD24545"),
            //    BarTextColor = Color.FromHex("#FFFFFF"),
            //    IsVisible = false
            //};

            //MainPage = navigationPage;

            //using (var db = new DbContext())
            //{
            //    var lst = db.ListAll();
            //}


            MainPage = new ProfilePage();
        }
    }
}
