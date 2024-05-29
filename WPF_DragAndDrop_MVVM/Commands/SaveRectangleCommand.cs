using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_DragAndDrop_MVVM.ViewModels;

namespace WPF_DragAndDrop_MVVM.Commands
{
    internal class SaveRectangleCommand : BaseCommand
    {
        private readonly DragAndDropCanvasViewModel _dragAndDropCanvasViewModel;

        public SaveRectangleCommand(DragAndDropCanvasViewModel dragAndDropCanvasViewModel)
        {
            _dragAndDropCanvasViewModel = dragAndDropCanvasViewModel;
        }

        public override void Execute(object? parameter)
        {
            MessageBox.Show($"sucessfully saved the rectangle to position {_dragAndDropCanvasViewModel.X} {_dragAndDropCanvasViewModel.Y}");
        }
    }
}
