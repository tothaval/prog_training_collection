using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dashboard.Models;

namespace Dashboard.ViewModels
{
    internal class ProductsViewModel : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public string ProductAvailability
        {
            get { return _pageModel.ProductStatus; }
            set
            {
                _pageModel.ProductStatus = value;
                OnPropertyChanged();
            }
        }

        public ProductsViewModel()
        {
            _pageModel = new PageModel();
            ProductAvailability = "Out of Stock";
        }

    }
}
