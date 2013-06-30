using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Dialog.Droid.Views;
using Cirrious.MvvmCross.Droid.Views;
using CrossUI.Droid.Dialog.Elements;
using DialogExamples.Core.ViewModels;

namespace DialogExamples.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxDialogActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var bindings = this.CreateInlineBindingTarget<FirstViewModel>();

            var passwordElement = new EntryElement("Password", "Enter Password").Bind(bindings, vm => vm.PasswordProperty);
            passwordElement.Password = true;

            Root = new RootElement("Example Root")
                {
                    new Section("Your details")
                        {
                            new EntryElement("Login", "Enter Login name").Bind(bindings, vm => vm.TextProperty),
                            passwordElement,
                        },
                    new Section("Your options")
                        {
                            new BooleanElement("Remember me?").Bind(bindings, vm => vm.SwitchThis),
                            new CheckboxElement("Upgrade?").Bind(bindings, vm => vm.CheckThis),
                        },
                    new Section("Action")
                        {
                            new ButtonElement("Go").Bind(bindings, element => element.SelectedCommand, vm => vm.GoCommand)  
                        },
                    new Section("Debug out:")
                        {
                            new StringElement("Login is:").Bind(bindings, vm => vm.TextProperty),
                            new StringElement("Password is:").Bind(bindings, vm => vm.PasswordProperty),
                            new StringElement("Remember is:").Bind(bindings, vm => vm.SwitchThis),
                            new StringElement("Upgrade is:").Bind(bindings, vm => vm.CheckThis),
                        },
                };
        }
    }
}