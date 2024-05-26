using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Training6_Login.Stores
{
    public class PeopleStore
    {
        public event Action<string> PersonAdded;

        public void AddPerson(string name)
        {
            PersonAdded?.Invoke(name);
        }
    }
}