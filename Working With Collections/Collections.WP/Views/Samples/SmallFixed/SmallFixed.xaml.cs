using Cirrious.MvvmCross.WindowsPhone.Views;
using Collections.Core.ViewModels.Samples.SmallFixed;

namespace Collections.WP.Views.Samples.SmallFixed
{
    public partial class SmallFixed : MvxPhonePage
    {
        public new SmallFixedViewModel ViewModel
        {
            get { return (SmallFixedViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public SmallFixed()
        {
            InitializeComponent();
        }
    }
}