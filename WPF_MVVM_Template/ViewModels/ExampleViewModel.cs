using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_Template.Commands;

namespace WPF_MVVM_Template.ViewModels
{
    class ExampleViewModel : BaseViewModel
    {
        private string exampleBinding;

        public string ExampleBinding
        {
            get { return exampleBinding; }
            set { exampleBinding = value; OnPropertyChanged(nameof(ExampleBinding)); }
        }


        private string bindingExample;

        public string BindingExample
        {
            get { return bindingExample; }
            set { bindingExample = value; OnPropertyChanged(nameof(BindingExample)); }
        }

        public ICommand ExampleCommand { get; set; }

        public ExampleViewModel()
        {
            ExampleCommand = new CommandExample(this);

        }
    }
}
