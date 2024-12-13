using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace WeatherApp.Platforms.Android
{
    [Activity(Label = "WeatherApp", Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MauiAppCompatActivity
    {
    }
}
