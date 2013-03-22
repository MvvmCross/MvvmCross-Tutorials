using Cirrious.MvvmCross.WindowsPhone.Views;
using Collections.Core.ViewModels.Samples.LargeDynamic;

namespace Collections.WP.Views.Samples.LargeDynamic
{
    public partial class LargeDynamic : MvxPhonePage
    {
        public new LargeDynamicViewModel ViewModel
        {
            get { return (LargeDynamicViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public LargeDynamic()
        {
            InitializeComponent();
        }
    }
}