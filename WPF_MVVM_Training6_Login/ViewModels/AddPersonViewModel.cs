using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_Training6_Login.Commands;
using WPF_MVVM_Training6_Login.Services;
using WPF_MVVM_Training6_Login.Stores;

namespace WPF_MVVM_Training6_Login.ViewModels
{
    public class AddPersonViewModel : BaseViewModel
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public AddPersonViewModel(PeopleStore peopleStore, INavigationService closeNavigationService)
        {
            SubmitCommand = new AddPersonCommand(this, peopleStore, closeNavigationService);
            CancelCommand = new NavigateCommand(closeNavigationService);
        }
    }
}