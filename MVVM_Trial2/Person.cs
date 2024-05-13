using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Haley.Models;
using Haley.Abstractions;
using Haley.MVVM;

namespace MVVM_Trial2
{
    public class Person : ChangeNotifier
    {

        private string _FName;

		public string FName
		{
			get { return _FName; }
			set { _FName = value; OnPropertyChanged(nameof(FName)); }
		}


        private string _LName;

        public string LName
        {
            get { return _LName; }
            set { _LName = value; OnPropertyChanged(nameof(LName)); }
        }

        private int _Age;

        public int Age
        {
            get { return _Age; }
            set { _Age = value; OnPropertyChanged(nameof(Age)); }
        }
    }
}
