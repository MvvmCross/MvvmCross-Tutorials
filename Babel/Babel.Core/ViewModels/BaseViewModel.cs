using MvvmCross.Localization;
using MvvmCross.Core.ViewModels;

namespace Babel.Core.ViewModels
{
    public abstract class BaseViewModel
        : MvxViewModel
    {
        public IMvxLanguageBinder TextSource
        {
            get { return new MvxLanguageBinder(Constants.GeneralNamespace, GetType().Name); }
        }
    }
}