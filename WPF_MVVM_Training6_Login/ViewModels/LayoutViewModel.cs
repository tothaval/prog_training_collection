using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Training6_Login.ViewModels
{
    internal class LayoutViewModel : BaseViewModel
    {
        public LayoutViewModel(NavigationBarViewModel navigationBarVM, BaseViewModel contentViewModel)
        {
            NavigationBarVM = navigationBarVM;
            ContentViewModel = contentViewModel;
        }

        public NavigationBarViewModel NavigationBarVM { get; }
        public BaseViewModel ContentViewModel { get; }

        public override void Dispose()
        {
            NavigationBarVM.Dispose();
            ContentViewModel.Dispose();

            base.Dispose();
        }
    }
}
