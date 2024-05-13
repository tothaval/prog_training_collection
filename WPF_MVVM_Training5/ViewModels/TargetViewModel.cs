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
    class TargetViewModel : BaseViewModel
    {
        private string targetHeaderText;

        public string TargetHeaderText
        {
            get { return targetHeaderText; }
            set { targetHeaderText = value; OnPropertyChanged(nameof(TargetHeaderText)); }
        }

        public ICommand HeadBackCommand { get; }

        public TargetViewModel(NavigationStore navigationStore, string text)
        {
            targetHeaderText = text;

            HeadBackCommand = new NavigateCommand<ExampleViewModel>(navigationStore, () => new ExampleViewModel(navigationStore));

        }
    }
}
