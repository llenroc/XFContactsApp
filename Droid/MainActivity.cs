
using Android.App;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Xamarin.Forms.Platform.Android;

namespace XFContactsApp.Droid
{
    [Activity(Label = "XFContactsApp.Droid", Icon = "@drawable/icon", Theme = "@style/MyCustomTheme"
              , MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ActionBar.SetIcon(Color.Transparent);
            Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);

            Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new App());
        }
    }
}

