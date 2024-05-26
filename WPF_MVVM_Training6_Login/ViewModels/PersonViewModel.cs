using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Training6_Login.ViewModels
{
    public class PersonViewModel : BaseViewModel
    {
        public string Name { get; }

        public PersonViewModel(string name)
        {
            Name = name;
        }
    }
}