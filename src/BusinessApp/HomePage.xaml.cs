using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BusinessApp
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        async void OnAddSettingsActivated(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SettingsPage());
        }

    }
}
