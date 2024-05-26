using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dashboard.Models;

namespace Dashboard.ViewModels
{
    internal class OrdersViewModel : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public DateOnly DisplayOrderDate
        {
            get { return _pageModel.OrderDate; }
            set
            {
                _pageModel.OrderDate = value;
                OnPropertyChanged();
            }
        }

        public OrdersViewModel()
        {
            _pageModel = new PageModel();
            DisplayOrderDate = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
