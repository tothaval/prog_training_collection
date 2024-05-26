using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dashboard.Models;

namespace Dashboard.ViewModels
{
    internal class CustomersViewModel : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public int CustomerID
        {
            get { return _pageModel.CustomerCount; }
            set
            {
                _pageModel.CustomerCount = value;
                OnPropertyChanged();
            }
        }

        public CustomersViewModel()
        {
            _pageModel = new PageModel();
            CustomerID = 100528;
                
        }

    }
}
