using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_Training5.Commands;
using WPF_MVVM_Training5.Navigation;

namespace WPF_MVVM_Training5.ViewModels
{
    internal class ExampleViewModel : BaseViewModel
    {
        private string exampleBinding;
        private NavigationStore _navigationStore;

        public string ExampleBinding
        {
            get { return exampleBinding; }
            set { exampleBinding = value; OnPropertyChanged(nameof(ExampleBinding)); }
        }


        private string bindingExample;

        public string BindingExample
        {
            get { return bindingExample; }
            set { bindingExample = value; OnPropertyChanged(nameof(BindingExample)); }
        }

        public ICommand ExampleCommand { get; set; }
        public ICommand SwitchToTargetCommand { get; set; }

        public ExampleViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            ExampleCommand = new CommandExample(this);
            SwitchToTargetCommand = new NavigateCommand<TargetViewModel>(_navigationStore, () => new TargetViewModel(_navigationStore, exampleBinding));

        }
    }
}
