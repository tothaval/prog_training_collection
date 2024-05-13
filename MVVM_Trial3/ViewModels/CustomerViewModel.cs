

namespace MVVM_Trial3.ViewModels
{
    using System;
    using System.Diagnostics;
    using System.Windows.Input;
    using MVVM_Trial3.Commands;
    using MVVM_Trial3.Models;

    internal class CustomerViewModel
    {
        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class.
        /// </summary>
        public CustomerViewModel()
        {
            _customer = new Customer("Stephan");
            UpdateCommand = new CustomerUpdateCommand(this);
        }


        /// <summary>
        /// gets or sets a system.boolean value indicating whether the Customer can be updated.
        /// </summary>
        public bool CanUpdate {
            get
            {
                if (customer == null)
                {
                    return false;
                }

                return !String.IsNullOrWhiteSpace(customer.Name);
            }  
        }


        private Customer _customer;

        /// <summary>
        /// gets the customer instance
        /// </summary>
        public Customer customer
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
            _customer.Output = _customer.Name;
            //Debug.Assert(false, String.Format("{0} was updated.", customer.Name));
        }
    }
}
