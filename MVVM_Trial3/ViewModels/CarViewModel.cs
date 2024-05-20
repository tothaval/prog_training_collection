using MVVM_Trial3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Trial3.ViewModels
{
    internal class CarViewModel : INotifyPropertyChanged
    {
        public CarViewModel()
        {
                Car = new Car()
                {
                    MyCar = "Spitzenflitzer"
                };
        }

        public Car Car
        {
            get; set;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
