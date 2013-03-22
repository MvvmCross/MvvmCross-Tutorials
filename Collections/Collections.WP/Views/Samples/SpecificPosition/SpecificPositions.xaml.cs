using Cirrious.MvvmCross.WindowsPhone.Views;
using Collections.Core.ViewModels.Samples.SpecificPositions;

namespace Collections.WP.Views.Samples.SpecificPosition
{
    public partial class SpecificPositions : MvxPhonePage
    {
        public new SpecificPositionsViewModel ViewModel
        {
            get { return (SpecificPositionsViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public SpecificPositions()
        {
            InitializeComponent();
        }
    }

}