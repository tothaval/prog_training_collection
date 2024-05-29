using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_DragAndDrop_MVVM.ViewModels;

namespace WPF_DragAndDrop_MVVM.Commands
{
    public class TodoItemReceivedCommand : BaseCommand
    {
        private readonly TodoItemListingViewModel _todoItemListingViewModel;

        public TodoItemReceivedCommand(TodoItemListingViewModel todoItemListingViewModel)
        {
            _todoItemListingViewModel = todoItemListingViewModel;
        }

        public override void Execute(object parameter)
        {
            _todoItemListingViewModel.AddTodoItem(_todoItemListingViewModel.IncomingTodoItemViewModel);
        }
    }
}