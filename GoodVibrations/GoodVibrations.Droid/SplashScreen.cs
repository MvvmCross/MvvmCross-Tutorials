using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace GoodVibrations.Droid
{
    [Activity(Label = "GoodVibrations.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}