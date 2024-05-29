using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_DragAndDrop_MVVM.ViewModels;

namespace WPF_DragAndDrop_MVVM.Commands
{
    public class TodoItemInsertedCommand : BaseCommand
    {
        private readonly TodoItemListingViewModel _viewModel;

        public TodoItemInsertedCommand(TodoItemListingViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            _viewModel.InsertTodoItem(_viewModel.InsertedTodoItemViewModel, _viewModel.TargetTodoItemViewModel);
        }
    }
}