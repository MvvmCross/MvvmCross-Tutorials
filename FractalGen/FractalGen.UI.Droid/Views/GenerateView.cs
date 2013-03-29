using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.Droid.Views;
using FractalGen.Core.Services;
using FractalGen.Core.ViewModels;
using FractalGen.UI.Droid.UIServices;

namespace FractalGen.UI.Droid.Views
{
    [Activity(Label = "My Activity", ScreenOrientation = ScreenOrientation.Landscape)]
    public class GenerateView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.View_Generate);
            HackSetDisplayDimensions();
            (ViewModel as GenerateViewModel)
                .RestartCommand.Execute(null);
        }

        private void HackSetDisplayDimensions()
        {
            var disp = (DisplayDimensionsService) Mvx.Resolve<IDisplayDimensionsService>();
            disp.Height = (int)(WindowManager.DefaultDisplay.Height * 0.8);
            disp.Width = (int)(WindowManager.DefaultDisplay.Width * 0.8);
        }
    }
}