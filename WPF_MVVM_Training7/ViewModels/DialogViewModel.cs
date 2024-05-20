using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_Training7.Commands;
using WPF_MVVM_Training7.Views;

namespace WPF_MVVM_Training7.ViewModels
{
    internal class DialogViewModel : ViewModelBase
    {
        private readonly IDialogService _dialogService;

        public ICommand DisplayMessageCommand { get; }

        public DialogViewModel(IDialogService dialogService)
        {
            DisplayMessageCommand = new RelayCommand(p => DisplayMessage());
            _dialogService = dialogService;
        }

        private void DisplayMessage()
        {
            var viewModel = new DialogWindowViewModel("Hello!");

            bool? result = _dialogService.ShowDialog(viewModel);

            if (result.HasValue)
            {
                if (result.Value)
                {
                    // Accepted
                }
                else
                {
                    // Cancelled
                }
            }
        }
    }
}
