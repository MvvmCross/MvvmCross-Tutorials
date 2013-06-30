using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace DialogExamples.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        public ICommand GoCommand
        {
            get { return new MvxCommand(() => ShowViewModel<SecondViewModel>());}
        }

        private bool _switchThis;
        public bool SwitchThis
        {
            get { return _switchThis; }
            set { _switchThis = value; RaisePropertyChanged(() => SwitchThis); }
        }

        private string _textProperty;
        public string TextProperty
        {
            get { return _textProperty; }
            set { _textProperty = value; RaisePropertyChanged(() => TextProperty); }
        }

        private string _passwordProperty;
        public string PasswordProperty
        {
            get { return _passwordProperty; }
            set { _passwordProperty = value; RaisePropertyChanged(() => PasswordProperty); }
        }

        private bool _checkThis;
        public bool CheckThis
        {
            get { return _checkThis; }
            set { _checkThis = value; RaisePropertyChanged(() => CheckThis); }
        }
    }
}
