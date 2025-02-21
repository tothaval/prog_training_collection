using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFBasics;

namespace WPF_MVVM_Training
{
    public class PersonListViewModel : BaseViewModel
    {
		public event EventHandler MissingData;

		public PersonListViewModel()
        {
			this.AddPersonCommand = new DelegateCommand(
				(o) =>
				{
					if (String.IsNullOrWhiteSpace(NewPerson.FirstName) || String.IsNullOrWhiteSpace(NewPerson.LastName))
						MissingData?.Invoke(this, EventArgs.Empty);
					else
					{
						// will be called on button click
						//if (!_Persons.Contains(NewPerson))
						//{
						//	this.Persons.Add(NewPerson);

						//	NewPerson = new Person();
						//}

						this.Persons.Add(NewPerson);

						NewPerson = new Person();
					}
				});

			this.Persons.Add(new Person()
			{ 
				Department = "Back Office",
				FirstName = "Susi",
				LastName = "Müller" 
			});

            this.Persons.Add(new Person()
            {
                Department = "Software Development",
                FirstName = "Dev",
                LastName = "Dave"
            });

            this.Persons.Add(new Person()
            {
                Department = "Management",
                FirstName = "Hugo",
                LastName = "Bossinger"
            });
        }


        private Person _NewPerson = new Person();
		public Person NewPerson
		{
			get => _NewPerson;
			set
			{
				if (_NewPerson != value)
				{
					_NewPerson = value; 
					
					this.RaisePropertyChanged();
				}				
			}
		}


		private ObservableCollection<Person> _Persons = new ObservableCollection<Person>();
        public ObservableCollection<Person> Persons
        {
            get { return _Persons; }
            set
            {
                if (_Persons != value)
                {
                    _Persons = value;
                }
                this.RaisePropertyChanged();
            }
        }


        public DelegateCommand AddPersonCommand
		{ get; set; }

	}
}
