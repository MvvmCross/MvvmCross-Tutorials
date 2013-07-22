using Cirrious.MvvmCross.ViewModels;

namespace QuickLayout.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        public void GoDetails()
        {
            ShowViewModel<DetailsViewModel>();
        }

        public void GoForm()
        {
            ShowViewModel<FormViewModel>();
        }
    }
}