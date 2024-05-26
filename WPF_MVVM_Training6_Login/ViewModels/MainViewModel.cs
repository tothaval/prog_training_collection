using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MVVM_Training6_Login.Commands;
using WPF_MVVM_Training6_Login.Stores;

namespace WPF_MVVM_Training6_Login.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private readonly NavigationStore _navigationStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;
        public BaseViewModel CurrentModalViewModel => _modalNavigationStore.CurrentViewModel;
        public bool IsOpen => _modalNavigationStore.IsOpen;

        public MainViewModel(NavigationStore navigationStore, ModalNavigationStore modalNavigationStore)
        {
            _navigationStore = navigationStore;
            _modalNavigationStore = modalNavigationStore;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            _modalNavigationStore.CurrentViewModelChanged += OnCurrentModalViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        private void OnCurrentModalViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentModalViewModel));
            OnPropertyChanged(nameof(IsOpen));
        }
    }
}