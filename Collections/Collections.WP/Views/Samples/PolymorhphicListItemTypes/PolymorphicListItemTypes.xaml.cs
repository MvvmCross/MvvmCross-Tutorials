using Cirrious.MvvmCross.WindowsPhone.Views;
using Collections.Core.ViewModels.Samples.MultipleListItemTypes;

namespace Collections.WP.Views.Samples.PolymorhphicListItemTypes
{
    public partial class PolymorphicListItemTypes : BasePolymorphicListItemTypes
    {
        public PolymorphicListItemTypes()
        {
            InitializeComponent();
        }
    }

    public class BasePolymorphicListItemTypes : MvxPhonePage<PolymorphicListItemTypesViewModel>
    { }
}
