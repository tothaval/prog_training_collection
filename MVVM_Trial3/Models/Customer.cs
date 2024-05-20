namespace MVVM_Trial3.Models
{
    using System;
    using System.ComponentModel;

    public class Customer : INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// initialize a new instance of the Customer class
        /// </summary>
        public Customer(string customerName)
        {
            Name = customerName;
        }

        private string _Name;

        /// <summary>
        /// gets or sets the customers name
        /// </summary>
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler? handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


        public string Error
        {
            get;
            private set;
        }
            

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Name")
                {
                    if (String.IsNullOrWhiteSpace(Name))
                    {
                        Error = "Name cannot be null or empty.";
                    }
                    else
                    {
                        Error = null;
                    }
                };

                return Error;
            }

        }
        
    }
}
