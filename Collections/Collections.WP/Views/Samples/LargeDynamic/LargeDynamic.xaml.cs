using Cirrious.MvvmCross.WindowsPhone.Views;
using Collections.Core.ViewModels.Samples.LargeDynamic;

namespace Collections.WP.Views.Samples.LargeDynamic
{
    public partial class LargeDynamic : BaseLargeDynamic
    {
        public LargeDynamic()
        {
            InitializeComponent();
        }
    }

    public class BaseLargeDynamic : MvxPhonePage<LargeDynamicViewModel>
    {}
}