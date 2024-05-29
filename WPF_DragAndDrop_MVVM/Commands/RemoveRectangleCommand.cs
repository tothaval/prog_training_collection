using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPF_DragAndDrop_MVVM.ViewModels;

namespace WPF_DragAndDrop_MVVM.Commands
{
    internal class RemoveRectangleCommand : BaseCommand
    {
        private readonly DragAndDropCanvasViewModel _dragAndDropCanvasViewModel;

        public RemoveRectangleCommand(DragAndDropCanvasViewModel dragAndDropCanvasViewModel)
        {
            _dragAndDropCanvasViewModel = dragAndDropCanvasViewModel;
        }


        public override void Execute(object? parameter)        
        {
            //MessageBox.Show(_dragAndDropCanvasViewModel.RemoveRectangleName);
            // crashes, conflicts with drag and drop
        }
    }
}
