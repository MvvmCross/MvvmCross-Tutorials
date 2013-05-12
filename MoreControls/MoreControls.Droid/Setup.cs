using Android.Content;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;

namespace MoreControls.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override System.Collections.Generic.IDictionary<string, string> ViewNamespaceAbbreviations
        {
            get
            {
                var toReturn = base.ViewNamespaceAbbreviations;
                toReturn["MC"] = "MoreControls.Droid.Controls";
                return toReturn;
            }
        }
    }
}