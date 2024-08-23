using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace ArtifactsMMO_Utility_Mobile
{
    [Activity(MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            if (this.Window != null)
            {
                this.Window.RequestFeature(WindowFeatures.NoTitle);
            }
            Window.SetFlags(Android.Views.WindowManagerFlags.Fullscreen, Android.Views.WindowManagerFlags.Fullscreen);
            base.OnCreate(savedInstanceState);
        }
    }
}
