using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_Training6_Login.Services;
using WPF_MVVM_Training6_Login.Stores;
using WPF_MVVM_Training6_Login.ViewModels;

namespace WPF_MVVM_Training6_Login.Commands
{
    public class LogoutCommand : BaseCommand
    {
        private readonly AccountStore _accountStore;

        public LogoutCommand(AccountStore accountStore)
        {
            _accountStore = accountStore;
        }

        public override void Execute(object parameter)
        {
            _accountStore.Logout();
        }
    }
}