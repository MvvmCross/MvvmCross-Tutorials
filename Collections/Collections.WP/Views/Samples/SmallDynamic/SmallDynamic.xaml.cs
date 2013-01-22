using Cirrious.MvvmCross.WindowsPhone.Views;
using Collections.Core.ViewModels.Samples.SmallDynamic;

namespace Collections.WP.Views.Samples.SmallDynamic
{
    public partial class SmallDynamic : BaseSmallDynamic
    {
        public SmallDynamic()
        {
            InitializeComponent();
        }
    }

    public class BaseSmallDynamic : MvxPhonePage<SmallDynamicViewModel>
    { }
}