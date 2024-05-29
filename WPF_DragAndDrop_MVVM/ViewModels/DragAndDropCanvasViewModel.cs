using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_DragAndDrop_MVVM.Commands;

namespace WPF_DragAndDrop_MVVM.ViewModels
{
    public class DragAndDropCanvasViewModel : ViewModelBase
    {
        private double _x;

        public double X
        {
            get { return _x; }
            set { _x = value;
                OnPropertyChanged(nameof(X));
            }
        }

        private int _y;

        public int Y
        {
            get { return _y; }
            set { _y = value;
                OnPropertyChanged(nameof(Y));
            }
        }

        private string removeRectangleName;

        public string RemoveRectangleName
        {
            get { return removeRectangleName; }
            set { removeRectangleName = value;
                OnPropertyChanged(nameof(RemoveRectangleName));
            }
        }



        public ICommand RemoveRectangleCommand { get; }
        public ICommand SaveRectangleCommand { get; }

        public DragAndDropCanvasViewModel()
        {
            RemoveRectangleCommand = new RemoveRectangleCommand(this);
            SaveRectangleCommand = new SaveRectangleCommand(this);


        }
    }
}
