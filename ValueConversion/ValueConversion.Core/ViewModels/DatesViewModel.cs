using System;
using Cirrious.MvvmCross.ViewModels;

namespace ValueConversion.Core.ViewModels
{
    public class DatesViewModel : MvxViewModel
    {
        public DatesViewModel()
        {
            _theDate = DateTime.Now;
        }

        private DateTime _theDate;
        public DateTime TheDate
        {
            get { return _theDate; }
            set { _theDate = value; RaisePropertyChanged(() => TheDate); }
        }
    }
}