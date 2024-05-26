using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dashboard.Models;

namespace Dashboard.ViewModels
{
    internal class TransactionsViewModel : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public decimal TransactionAmount
        {
            get { return _pageModel.TransactionValue; }
            set
            {
                _pageModel.TransactionValue = value;
                OnPropertyChanged();
            }
        }



        public TransactionsViewModel()
        {
            _pageModel = new PageModel();
            TransactionAmount = 5638;
        }
    }
}
