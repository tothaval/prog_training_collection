using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Trial3.Models
{
    internal class Car : IDataErrorInfo, INotifyPropertyChanged
    {
        private string myCar;

        public string MyCar
        {
            get { return myCar; }
            set { myCar = value; OnPropertyChanged("MyCar"); }
        }

        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler? handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


        static readonly string[] ValidatedProperties =
        {
            "MyCar"
        };

        public bool IsValid
        {
            get
            {
                foreach (string property in ValidatedProperties)
                {
                    if (GetValidationError(property) != null)
                        return false;
            
                }

                return true;
            }
        }

        public string this[string propertyName]
        {
            get
            {
                return GetValidationError(propertyName);
            }
        }

        string GetValidationError(String propertyName)
        {
            string error = null;

            switch (propertyName)
            {
                case "MyCar":
                    error = ValidateCarName();
                    break;
            }


            return error;
        }

        private string? ValidateCarName()
        {
            if (String.IsNullOrWhiteSpace(MyCar))
            {
                return "Car name cannot be empty.";
            }

            return null;
        }

        public string Error
        {
            get
            {
                return null;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
