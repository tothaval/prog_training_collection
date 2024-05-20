using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_Training7.Commands;

namespace WPF_MVVM_Training7.ViewModels
{
    internal class DialogWindowViewModel : IDialogRequestClose
    {
        public string Message { get; }

        public DialogWindowViewModel(string message)
        {
            Message = message;

            OkCommand = new RelayCommand(
                p => CloseRequested?.Invoke(this, new DialogCloseRequestedEventArgs(true))
                );

            CancelCommand = new RelayCommand(
                p => CloseRequested?.Invoke(this, new DialogCloseRequestedEventArgs(false))
                );
        }

        public ICommand OkCommand { get; }
        public ICommand CancelCommand { get; }

        public event EventHandler<DialogCloseRequestedEventArgs> CloseRequested;
    }
}
