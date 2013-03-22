using Cirrious.MvvmCross.WindowsPhone.Views;
using Collections.Core.ViewModels.Samples.SmallDynamic;

namespace Collections.WP.Views.Samples.SmallDynamic
{
    public partial class SmallDynamic : MvxPhonePage
    {
        public new SmallDynamicViewModel ViewModel
        {
            get { return (SmallDynamicViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public SmallDynamic()
        {
            InitializeComponent();
        }
    }

}