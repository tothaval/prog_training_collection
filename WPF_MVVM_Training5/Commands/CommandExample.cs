using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_Training5.ViewModels;

namespace WPF_MVVM_Training5.Commands
{
    internal class CommandExample : BaseCommand
    {
        private readonly ExampleViewModel _viewModel;

        public override void Execute(object? parameter)
        {
            if (parameter != null)
            {
                _viewModel.BindingExample = $"{_viewModel.ExampleBinding}\n" +
                $"responsible {parameter}";
            }
        }

        public CommandExample(ExampleViewModel exampleViewModel)
        {
            _viewModel = exampleViewModel;

        }
    }
}
