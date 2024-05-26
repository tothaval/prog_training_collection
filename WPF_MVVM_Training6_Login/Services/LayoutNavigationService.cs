using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_Training6_Login.Stores;
using WPF_MVVM_Training6_Login.ViewModels;

namespace WPF_MVVM_Training6_Login.Services
{
    public class LayoutNavigationService<TViewModel> : INavigationService where TViewModel : BaseViewModel
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _createViewModel;
        private readonly Func<NavigationBarViewModel> _createNavigationBarViewModel;

        public LayoutNavigationService(NavigationStore navigationStore,
            Func<TViewModel> createViewModel,
            Func<NavigationBarViewModel> createNavigationBarViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
            _createNavigationBarViewModel = createNavigationBarViewModel;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = new LayoutViewModel(_createNavigationBarViewModel(), _createViewModel());
        }
    }
}