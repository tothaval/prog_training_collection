using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Haley.Models;
using Haley.Abstractions;
using Haley.MVVM;

namespace MVVM_Trial2
{
    public class MainVM : ChangeNotifier
    {
        private Person person;

        public Person TargetPerson
        {
            get { return person; }
            set { person = value; OnPropertyChanged(nameof(TargetPerson)); }
        }

        private ObservableCollection<Person> _persons;

        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }


        public void AddPerson()
        {
            Persons.Add(TargetPerson); // add it to the collection
            TargetPerson = new Person(); // resetting
        }

        public ICommand CMDAdd => new DelegateCommand(AddPerson);
        public ICommand CMDDelete => new DelegateCommand<Person>(DeletePerson);

        private void DeletePerson(Person obj)
        {
            if (obj == null) return;
            if (!Persons.Contains(obj)) return;
            
            Persons.Remove(obj);         
        }

        public MainVM()
        {
            Persons = new ObservableCollection<Person>();
            TargetPerson = new Person();
        }
    }
}
