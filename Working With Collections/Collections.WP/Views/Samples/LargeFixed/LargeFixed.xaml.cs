using Cirrious.MvvmCross.WindowsPhone.Views;
using Collections.Core.ViewModels.Samples.LargeFixed;

namespace Collections.WP.Views.Samples.LargeFixed
{
    public partial class LargeFixed : MvxPhonePage
    {
        public new LargeFixedViewModel ViewModel
        {
            get { return (LargeFixedViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public LargeFixed()
        {
            InitializeComponent();
        }
    }
}