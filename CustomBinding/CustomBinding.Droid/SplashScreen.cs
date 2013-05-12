using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace CustomBinding.Droid
{
    [Activity(Label = "CustomBinding.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}