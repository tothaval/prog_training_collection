using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using WPF_MVVM_Training9.Commands;
using WPF_MVVM_Training9.Models;

namespace WPF_MVVM_Training9.ViewModels
{
    class AddUserViewModel
    {
        public ICommand AddUserCommand { get; }

        public string? Name { get; set; }
        public string? Email { get; set; }

        public AddUserViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser, CanAddUser);
                
        }

        private bool CanAddUser(object obj)
        {
            return true;
        }

        private void AddUser(object obj)
        {
            if (obj is Views.AddUser addUserWindow)
            {
                addUserWindow.Close();
            }

            UserManager.AddUser(new User() { Email = Email, Name = Name });
        }
    }
}
