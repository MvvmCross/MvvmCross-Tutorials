using MvvmCross.Binding.BindingContext;

namespace DialogExamples.iOS.BindableElements
{
    public interface IBindableElement
        : IMvxBindingContextOwner
    {
        object DataContext { get; set; }
    }
}
