using Android.App;
using Android.Content.PM;
using Android.OS;

namespace ThePresent.Droid
{
    [Activity(Label = "ThePresent", Icon = "@mipmap/icon", NoHistory = true, Theme = "@style/SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
        }
    }
}