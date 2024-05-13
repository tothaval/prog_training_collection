
namespace MVVM_Trial3.Commands
{
    using MVVM_Trial3.ViewModels;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;

    internal class CustomerUpdateCommand : ICommand
    {
        /// <summary>
        /// initializes a new instance of the CustomerUpdateCommand class.
        /// </summary>
        /// <param name="viewModel"></param>
        public CustomerUpdateCommand(CustomerViewModel viewModel)
        {
            _ViewModel = viewModel;
        }

        private CustomerViewModel _ViewModel;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _ViewModel.CanUpdate;
        }

        public void Execute(object? parameter)
        {
            _ViewModel.SaveChanges();
        }


    }
}
