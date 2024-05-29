using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_DragAndDrop_MVVM.ViewModels
{
    public class TodoViewModel : ViewModelBase
    {
        public TodoItemListingViewModel InProgressTodoItemListingViewModel { get; }
        public TodoItemListingViewModel CompletedTodoItemListingViewModel { get; }

        public TodoViewModel(TodoItemListingViewModel inProgressTodoItemListingViewModel, TodoItemListingViewModel completedTodoItemListingViewModel)
        {
            InProgressTodoItemListingViewModel = inProgressTodoItemListingViewModel;
            CompletedTodoItemListingViewModel = completedTodoItemListingViewModel;
        }
    }
}
