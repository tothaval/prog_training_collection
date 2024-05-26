using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dashboard.Models;

namespace Dashboard.ViewModels
{
    internal class SettingsViewModel : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public bool Settings
        {
            get { return _pageModel.LocationStatus; }
            set { _pageModel.LocationStatus = value;
                OnPropertyChanged();
            }
        }

        public SettingsViewModel()
        {
            _pageModel = new PageModel();
            Settings = true;
                
        }

    }
}
