using Android.App;
using Xamarin.Forms.Platform.Android;
using Android.OS;
using Android.Content.PM;

namespace BusinessApp.Droid
{
    //[Activity(Label = "BusinessApp", MainLauncher = false)]
    [Activity(Label = "HiddenActivityIconDemo",
        Icon = "@drawable/icon",
        MainLauncher = false,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

