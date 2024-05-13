namespace MVVM_Trial3.Models
{
    using System;
    using System.ComponentModel;

    public class Customer : INotifyPropertyChanged
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

        private string _Output;

        /// <summary>
        /// gets or sets the customers name
        /// </summary>
        public string Output
        {
            get
            {
                return _Output;
            }
            set
            {
                _Output = value;
                OnPropertyChanged("Output");
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
    }
}
