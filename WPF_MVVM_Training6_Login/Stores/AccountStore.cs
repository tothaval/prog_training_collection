using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WPF_MVVM_Training6_Login.Models;

namespace WPF_MVVM_Training6_Login.Stores
{
    internal class AccountStore
    {
        private Account _currentAccount;
        public Account CurrentAccount {
            get => _currentAccount;
            set {
                _currentAccount = value;
                CurrentAccountChanged?.Invoke();
            } }

        public bool IsLoggedIn => CurrentAccount != null;

        public event Action CurrentAccountChanged;

        public void logout()
        {
            CurrentAccount = null;
        }
    }
}
