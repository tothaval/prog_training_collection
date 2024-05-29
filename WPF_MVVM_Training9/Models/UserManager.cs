using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Training9.Models
{
    public class UserManager
    {

        public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>()
        {
            new User() { Name="Ulys", Email="Ulys@GuldanHost.kor" },
            new User() { Name="Jux", Email="Jux@ServerFarm.mer" },
            new User() { Name="Friend", Email="01Friend@Hosting.san" },
            new User() { Name="Bemfif", Email="Bemfif@ServerFarm.mer" },
            new User() { Name="oipu", Email="oipu@GuldanHost.kor" }
        };


        public static ObservableCollection<User> GetUsers()
        {
            return _DatabaseUsers;
        }


        public static void AddUser(User user)
        {
            if (!_DatabaseUsers.Contains(user))
            {
                _DatabaseUsers.Add(user);
            }
        }
            
            


    }
}
