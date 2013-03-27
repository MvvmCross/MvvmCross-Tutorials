using System;
using Cirrious.MvvmCross.ViewModels;

namespace ValueConversion.Core.ViewModels
{
    public class DatesViewModel : MvxViewModel
    {
        public DatesViewModel()
        {
            _theDate = DateTime.UtcNow;
            _oldDate = DateTime.UtcNow.Add(-TimeSpan.FromMinutes(33.0));
            _veryOldDate = DateTime.UtcNow.Add(-TimeSpan.FromDays(4.0));
        }

        private DateTime _theDate;
        public DateTime TheDate
        {
            get { return _theDate; }
            set { _theDate = value; RaisePropertyChanged(() => TheDate); }
        }

        private DateTime _oldDate;
        public DateTime OldDate
        {
            get { return _oldDate; }
            set { _oldDate = value; RaisePropertyChanged(() => OldDate); }
        }

        private DateTime _veryOldDate;
        public DateTime VeryOldDate
        {
            get { return _veryOldDate; }
            set { _veryOldDate = value; RaisePropertyChanged(() => VeryOldDate); }
        }
    }
}