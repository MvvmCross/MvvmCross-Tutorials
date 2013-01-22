using Cirrious.MvvmCross.WindowsPhone.Views;
using Collections.Core.ViewModels.Samples.LargeFixed;

namespace Collections.WP.Views.Samples.LargeFixed
{
    public partial class LargeFixed : BaseLargeFixed
    {
        public LargeFixed()
        {
            InitializeComponent();
        }
    }

    public class BaseLargeFixed : MvxPhonePage<LargeFixedViewModel> 
    {}
}