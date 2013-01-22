using Cirrious.MvvmCross.WindowsPhone.Views;
using Collections.Core.ViewModels.Samples.SmallFixed;

namespace Collections.WP.Views.Samples.SmallFixed
{
    public partial class SmallFixed : BaseSmallFixed
    {
        public SmallFixed()
        {
            InitializeComponent();
        }
    }

    public class BaseSmallFixed : MvxPhonePage<SmallFixedViewModel>
    {}
}