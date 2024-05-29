using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_DragAndDrop_MVVM.ViewModels
{
    public class TodoItemViewModel : ViewModelBase
    {
		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value;
				OnPropertyChanged(nameof(Description));
			}
		}

        public TodoItemViewModel(string description)
        {
			Description = description;				
        }
    }
}
