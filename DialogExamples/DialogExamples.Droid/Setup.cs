using Android.Content;
using MvvmCross.Dialog.Droid;
using MvvmCross.Core.ViewModels;

namespace DialogExamples.Droid
{
    public class Setup : MvxAndroidDialogSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}