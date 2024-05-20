

namespace MVVM_Trial3.ViewModels
{
    using System;
    using System.Diagnostics;
    using System.Windows.Input;
    using MVVM_Trial3.Commands;
    using MVVM_Trial3.Models;
    using MVVM_Trial3.Views;

    internal class CustomerViewModel
    {
        private Customer _customer;
        private CustomerInfoViewModel childViewModel;

        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class.
        /// </summary>
        public CustomerViewModel()
        {
            _customer = new Customer("Stephan");
            
            childViewModel = new CustomerInfoViewModel() {
                Info = "Instantiated in CustomerViewModel() ctor."};

            UpdateCommand = new CustomerUpdateCommand(this);
        }


        /// <summary>
        /// gets the Customer instance
        /// </summary>
        public Customer Customer
        {
            get
            {
                return _customer;
            }
            set
            {
                _customer = value;
            }
        }

        /// <summary>
        /// gets the UpdateCommand for the ViewModel
        /// </summary>
        public ICommand UpdateCommand
        {
            get;
            private set;
        }

        /// <summary>
        /// save changes made to the Customer instance.
        /// </summary>
        public void SaveChanges()
        {
            CustomerInfoView view = new CustomerInfoView();
            view.DataContext = childViewModel;

            //childViewModel.Info = Customer.Name + " was updated in the database.";

            view.ShowDialog();
        }
    }
}
