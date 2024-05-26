using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_Training6_Login.Commands;
using WPF_MVVM_Training6_Login.Services;
using WPF_MVVM_Training6_Login.Stores;

namespace WPF_MVVM_Training6_Login.ViewModels
{
    public class PeopleListingViewModel : BaseViewModel
    {
        private readonly PeopleStore _peopleStore;

        private readonly ObservableCollection<PersonViewModel> _people;

        public IEnumerable<PersonViewModel> People => _people;

        public ICommand AddPersonCommand { get; }

        public PeopleListingViewModel(PeopleStore peopleStore, INavigationService addPersonNavigationService)
        {
            _peopleStore = peopleStore;

            AddPersonCommand = new NavigateCommand(addPersonNavigationService);
            _people = new ObservableCollection<PersonViewModel>();

            _people.Add(new PersonViewModel("Stephan"));
            _people.Add(new PersonViewModel("FractalVoid"));
            _people.Add(new PersonViewModel("VoidMage"));
            _people.Add(new PersonViewModel("TothAval"));

            _peopleStore.PersonAdded += OnPersonAdded;
        }

        private void OnPersonAdded(string name)
        {
            _people.Add(new PersonViewModel(name));
        }
    }
}