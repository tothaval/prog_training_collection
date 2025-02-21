using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFBasics;

namespace WPF_MVVM_Training
{
    public class Person : NotifyableBaseObject
    {


        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
                this.RaisePropertyChanged();
                this.RaisePropertyChanged(nameof(FullName));
            }
        }


        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set
            {
                _LastName = value;
                this.RaisePropertyChanged();
                this.RaisePropertyChanged(nameof(FullName));
            }
        }


        public string FullName => $"{FirstName} {LastName}";


        private string _Department;
        public string Department
        {
            get { return _Department; }
            set
            {
                _Department = value;
                this.RaisePropertyChanged();
            }
        }


    }
}
