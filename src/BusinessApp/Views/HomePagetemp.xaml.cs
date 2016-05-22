using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BusinessApp.Views
{
    public partial class HomePagetemp : ContentPage
    {
        public HomePagetemp()
        {
            InitializeComponent();
        }

        async void OnAddSettingsActivated(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SettingsPage());
        }

    }
}
