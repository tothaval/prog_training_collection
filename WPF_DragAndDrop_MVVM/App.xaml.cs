using System.Configuration;
using System.Data;
using System.Windows;
using WPF_DragAndDrop_MVVM.ViewModels;

namespace WPF_DragAndDrop_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {


        protected override void OnStartup(StartupEventArgs e)
        {
            TodoItemListingViewModel inProgressTodoItemListingViewModel = new TodoItemListingViewModel();
            inProgressTodoItemListingViewModel.AddTodoItem(new TodoItemViewModel("Go jogging"));
            inProgressTodoItemListingViewModel.AddTodoItem(new TodoItemViewModel("Walk the dog"));
            inProgressTodoItemListingViewModel.AddTodoItem(new TodoItemViewModel("Make videos"));

            TodoItemListingViewModel completedTodoItemListingViewModel = new TodoItemListingViewModel();
            completedTodoItemListingViewModel.AddTodoItem(new TodoItemViewModel("Take a shower"));
            completedTodoItemListingViewModel.AddTodoItem(new TodoItemViewModel("Eat breakfast"));

            TodoViewModel todoViewModel = new TodoViewModel(inProgressTodoItemListingViewModel, completedTodoItemListingViewModel);

            MainWindow mainWindow = new MainWindow()
            {
                DataContext = todoViewModel
            };

            mainWindow.Show();

            base.OnStartup(e);
        }
    }

}
