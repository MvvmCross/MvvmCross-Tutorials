using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Converters;
using Cirrious.MvvmCross.ViewModels;

namespace ApiExamples.Core.ViewModels
{
    public class StripConverter : MvxValueConverter<string, string>
    {
        protected override string Convert(string value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value.Replace((string)parameter, string.Empty);
        }
    }

    public class FirstViewModel 
		: MvxViewModel
    {
        public FirstViewModel(IAllTestsService service)
        {
            Tests = service.All;
        }

        private IList<Type> _tests;
        public IList<Type> Tests
        {
            get { return _tests; }
            set { _tests = value; RaisePropertyChanged(() => Tests); }
        }
        
        public ICommand GotoTestCommand
        {
            get { return new MvxCommand<Type>(type => ShowViewModel(type)); }
        }
    }

    public abstract class TestViewModel
        : MvxViewModel
    {
        public ICommand NextCommand
        {
            get
            {
                return new MvxCommand(() =>
                    {
                        var all = Mvx.Resolve<IAllTestsService>();
                        var next = all.NextViewModelType(this);
                        if (next == null)
                            Close(this);
                        else
                            ShowViewModel(next);
                    });
            }
        }
    }

    public class DateTimeViewModel
        : TestViewModel
    {
        private DateTime _property = DateTime.Now;
        public DateTime Property
        {
            get { return _property; }
            set { _property = value; RaisePropertyChanged(() => Property); }
        }
    }

    public class TimeViewModel
        : TestViewModel
    {
        private TimeSpan _property = DateTime.Now.TimeOfDay;
        public TimeSpan Property
        {
            get { return _property; }
            set { _property = value; RaisePropertyChanged(() => Property); }
        }
    }

    public class SpinnerViewModel
        : TestViewModel
    {
        public class Thing
        {
            public Thing(string caption)
            {
                Caption = caption;
            }

            public string Caption { get; private set; }

            public override string ToString()
            {
                return Caption;
            }

            public override bool Equals(object obj)
            {
                var rhs = obj as Thing;
                if (rhs == null)
                    return false;
                return rhs.Caption == Caption;
            }

            public override int GetHashCode()
            {
                if (Caption == null)
                    return 0;
                return Caption.GetHashCode();
            }
        }
        private List<Thing> _items = new List<Thing>()
            {
                new Thing("One"),
                new Thing("Two"),
                new Thing("Three"),
                new Thing("Four"),
            };
        public List<Thing> Items
        {
            get { return _items; }
            set { _items = value; RaisePropertyChanged(() => Items); }
        }

        private Thing _selectedItem = new Thing("Three");
        public Thing SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; RaisePropertyChanged(() => SelectedItem); }
        }
    }

    public abstract class BaseListTestViewModel
        : TestViewModel
    {
        private ObservableCollection<string> _items = new ObservableCollection<string>()
            {
                "One", "Two", "Three"
            };
        public ObservableCollection<string> Items
        {
            get { return _items; }
            set { _items = value; RaisePropertyChanged(() => Items); }
        }

        private string _selected;
        public string Selected
        {
            get { return _selected; }
            set { _selected = value; RaisePropertyChanged(() => Selected); }
        }

        public ICommand AddCommand
        {
            get { return new MvxCommand(() => Items.Add(Guid.NewGuid().ToString("N"))); }
        }

        public ICommand RemoveCommand
        {
            get 
            { 
                return new MvxCommand(() =>
                {
                    if (Items.Count == 0)
                        return;
                    Items.RemoveAt(0);
                }); 
            }
        }

        public class ListViewModel : BaseListTestViewModel
        { }
        
        public class LinearLayoutViewModel : BaseListTestViewModel
        { }
        
        public class FrameViewModel : BaseListTestViewModel
        { }
        
        public class RelativeViewModel : BaseListTestViewModel
        { }

        public class TextViewModel : TestViewModel
        {
            private string _stringProperty = "Hello";
            public string StringProperty
            {
                get { return _stringProperty; }
                set { _stringProperty = value; RaisePropertyChanged(() => StringProperty); }
            }

            private double _doubleProperty = 42.12;
            public double DoubleProperty
            {
                get { return _doubleProperty; }
                set { _doubleProperty = value; RaisePropertyChanged(() => DoubleProperty); }
            }
        }

        public class SeekViewModel : TestViewModel
        {
            private double _seekProperty;
            public double SeekProperty
            {
                get { return _seekProperty; }
                set { _seekProperty = value; RaisePropertyChanged(() => SeekProperty); }
            }
        }

        public class ContainsSubViewModel : TestViewModel
        {
            public class PersonViewModel : MvxNotifyPropertyChanged
            {
                private string _firstName;
                public string FirstName
                {
                    get { return _firstName; }
                    set { _firstName = value; RaisePropertyChanged(() => FirstName); }
                }

                private string _lastName;
                public string LastName
                {
                    get { return _lastName; }
                    set { _lastName = value; RaisePropertyChanged(() => LastName); }
                }
            }

            private PersonViewModel _firstPerson = new PersonViewModel()
            {
                FirstName = "Fred",
                LastName = "Flintstone"
            };
            public PersonViewModel FirstPerson
            {
                get { return _firstPerson; }
                set { _firstPerson = value; RaisePropertyChanged(() => FirstPerson); }
            }

            private PersonViewModel _secondPerson = new PersonViewModel()
                {
                    FirstName = "Barney",
                    LastName = "Rubble"
                };
            public PersonViewModel SecondPerson
            {
                get { return _secondPerson; }
                set { _secondPerson = value; RaisePropertyChanged(() => SecondPerson); }
            }
        }
    }

    public class PlusTenValueConverter
        : MvxValueConverter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ((int)value) + 10;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return int.Parse((string)value) - 10;
        }
    }

    public class ConvertThisViewModel : TestViewModel
    {
        private int _value = 21;
        public int Value
        {
            get { return _value; }
            set { _value = value; RaisePropertyChanged(() => Value); }
        }
    }
}
