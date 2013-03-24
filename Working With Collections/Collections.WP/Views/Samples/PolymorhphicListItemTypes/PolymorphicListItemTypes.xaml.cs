using Cirrious.MvvmCross.WindowsPhone.Views;
using Collections.Core.ViewModels.Samples.MultipleListItemTypes;

namespace Collections.WP.Views.Samples.PolymorhphicListItemTypes
{
    public partial class PolymorphicListItemTypes : MvxPhonePage
    {
        public new PolymorphicListItemTypesViewModel ViewModel
        {
            get { return (PolymorphicListItemTypesViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public PolymorphicListItemTypes()
        {
            InitializeComponent();
        }
    }
}
