using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_Training9.Commands;
using WPF_MVVM_Training9.Models;
using WPF_MVVM_Training9.Views;

namespace WPF_MVVM_Training9.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public ICommand ShowWindowCommand { get; }

        public MainViewModel()
        {
            Users = UserManager.GetUsers();

            ShowWindowCommand = new RelayCommand(ShowWindowMethod, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindowMethod(object obj)
        {
            var mainWindow = obj as MainWindow;

            AddUser addUserWindow = new AddUser();

            addUserWindow.Owner = mainWindow;
            addUserWindow.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;

            addUserWindow.Show();
        }
    }
}
