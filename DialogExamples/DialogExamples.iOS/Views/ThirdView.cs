using MvvmCross.Binding.BindingContext;
using MvvmCross.Dialog.iOS;
using CrossUI.iOS.Dialog.Elements;
using DialogExamples.Core.ViewModels;
using DialogExamples.iOS.BindableElements;
using Foundation;

namespace DialogExamples.iOS.Views
{
    [Register("ThirdView")]
    public class ThirdView : MvxDialogViewController
    {
        public ThirdView()
            : base(pushing:true)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var bindings = this.CreateInlineBindingTarget<ThirdViewModel>();

            Root = new RootElement("Example Root")
                {
                    new Section("Choose a list")
                        {
                            new StringElement("Short List").Bind(bindings, element => element.SelectedCommand, vm => vm.ShortListCommand),
                            new StringElement("Long List").Bind(bindings, element => element.SelectedCommand, vm => vm.LongListCommand),
                        },
                    new BindableSection<CustomStringElement>("Bound String Elements")
                        .Bind(bindings, element => element.ItemsSource, vm => vm.People),
                    new BindableSection<CustomViewElement>("Bound Custom View Elements")
                        .Bind(bindings, element => element.ItemsSource, vm => vm.People)
                };
        }
    }
}