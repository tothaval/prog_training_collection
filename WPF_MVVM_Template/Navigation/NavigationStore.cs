using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_Template.ViewModels;

namespace WPF_MVVM_Template.Navigation
{
    class NavigationStore
    {
        private BaseViewModel _baseViewModel;

        public BaseViewModel CurrentViewModel
        { 
            get { return _baseViewModel; } 
            set
            {
                _baseViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        public event Action CurrentViewModelChanged;

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

    }
}
