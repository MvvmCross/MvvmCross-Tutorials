using System;
using System.IO;
using Windows.UI.Xaml.Controls;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using MvvmCross.Plugins.ResourceLoader.WindowsCommon;
using MvvmCross.WindowsUWP.Platform;

namespace Babel.WindowsUWP
{
    public class HackMvxStoreResourceLoader : MvxStoreResourceLoader
    {
        public override void GetResourceStream(string resourcePath, Action<Stream> streamAction)
        {
            // in 3.0.8.2 and earlier we needed to replace the "/" with "\\" :/
            resourcePath = resourcePath.Replace("/", "\\");
            base.GetResourceStream(resourcePath, streamAction);
        }
    }

    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            Mvx.RegisterType<IMvxResourceLoader, HackMvxStoreResourceLoader>();
            return new Core.App();
        }
    }
}