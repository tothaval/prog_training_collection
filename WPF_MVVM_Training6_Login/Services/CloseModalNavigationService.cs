using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_Training6_Login.Stores;

namespace WPF_MVVM_Training6_Login.Services
{
    public class CloseModalNavigationService : INavigationService
    {
        private readonly ModalNavigationStore _navigationStore;

        public CloseModalNavigationService(ModalNavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public void Navigate()
        {
            _navigationStore.Close();
        }
    }
}