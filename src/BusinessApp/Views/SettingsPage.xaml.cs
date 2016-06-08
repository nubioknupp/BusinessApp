using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Dao;
using BusinessApp.Model;
using Xamarin.Forms;

namespace BusinessApp.Views
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Profile profile;

            using (var db = new DbContext()){ profile = db.FillById(1);}

            Name.Text = profile.Name;
            Profession.Text = profile.Profession;
            Where.Text = profile.Where;
            Summary.Text = profile.Summary;

        }

        private void SaveClicked(object sender, EventArgs e)
        {
            var profile = new Profile
            {
                Id = 1,
                Name = Name.Text,
                Profession = Profession.Text,
                Where = Profession.Text,
                Summary = Summary.Text
            };

            using (var db = new DbContext())
            {
                db.InsertOrUpdate(profile);
            }
            NavigationProfile();
        }

        private void NavigationProfile()
        {
            Application.Current.MainPage = new NavigationPage(new ProfilePage());
        }

        private void Summary_OnFocused(object sender, EventArgs e)
        {
            if (Summary.Text.Trim() == "Resumo")
            {
                Summary.Text = "";
            }
        }

        private void Summary_OnUnfocused(object sender, FocusEventArgs e)
        {
            if (Summary.Text.Trim() == "")
            {
                Summary.Text = "Resumo";
            }
        }
    }
}
