using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;

namespace UEHtheTeam
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        // C# (Xamarin.Android) — add in Application.OnCreate or MainActivity.OnCreate
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                var ex = e.ExceptionObject as Exception;
                System.Diagnostics.Debug.WriteLine("Unhandled AppDomain exception: " + ex?.ToString());
            };

            AndroidEnvironment.UnhandledExceptionRaiser += (sender, e) =>
            {
                try
                {
                    var ex = e.Exception;
                    System.Diagnostics.Debug.WriteLine("AndroidEnvironment unhandled: " + ex?.ToString());
                    // If it's a JavaProxyThrowable, dump inner/Java info too
                    if (ex != null)
                    {
                        if (ex.InnerException != null)
                            System.Diagnostics.Debug.WriteLine("InnerException: " + ex.InnerException.ToString());
                        // Best-effort: print any additional properties
                        System.Diagnostics.Debug.WriteLine("StackTrace: " + ex.StackTrace);
                    }
                }
                finally
                {
                    // Let the runtime proceed with default handling
                }
            };
        }
    }
}
