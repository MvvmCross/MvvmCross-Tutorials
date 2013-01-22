using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Cirrious.MvvmCross.Commands;
using Collections.Core.ViewModels.Samples.ListItems;

namespace Collections.Core.ViewModels.Samples.SmallDynamic
{
    public class SmallDynamicViewModel : BaseSampleViewModel
    {
        private ObservableCollection<Kitten> _kittens;
        public ObservableCollection<Kitten> Kittens
        {
            get { return _kittens; }
            set { _kittens = value; RaisePropertyChanged(() => Kittens); }
        }

        public SmallDynamicViewModel()
        {
            Kittens = new ObservableCollection<Kitten>();
            foreach (var kitten in CreateKittens(10))
            {
                Kittens.Add(kitten);
            }
        }
 
        public ICommand AddKittenCommand
        {
            get
            {
                return new MvxRelayCommand(DoAddKitten);
            }
        }

        public ICommand KillKittensCommand
        {
            get
            {
                return new MvxRelayCommand(DoKillKittens);
            }
        }

        private void DoAddKitten()
        {
            var kitten = CreateKittens(1).First();
            Kittens.Add(kitten);
        }

        private void DoKillKittens()
        {
            var initialCount = Kittens.Count;
            while (Kittens.Count > initialCount/2)
            {
                Kittens.RemoveAt(0);
            }
        }
    }
}