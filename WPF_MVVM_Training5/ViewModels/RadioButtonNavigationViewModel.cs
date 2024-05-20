using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WPF_MVVM_Training5.Commands;
using WPF_MVVM_Training5.Views;

namespace WPF_MVVM_Training5.ViewModels
{
    internal class RadioButtonNavigationViewModel : BaseViewModel
    {
        public ICommand RadioButtonCommand;




        public RadioButtonNavigationViewModel()
        {
            RadioButtonCommand = new RadioButtonIsCheckedCommand();

        }
    }
}
