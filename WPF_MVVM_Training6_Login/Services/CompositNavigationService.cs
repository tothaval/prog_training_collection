using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Training6_Login.Services
{
    internal class CompositNavigationService : INavigationService
    {
        private readonly IEnumerable<INavigationService> _navigationServices;

        public CompositNavigationService(params INavigationService[] navigationService)
        {
            _navigationServices = navigationService;
        }

        public void Navigate()
        {
            foreach (INavigationService item in _navigationServices)
            {
                item.Navigate();
            }
        }
    }
}
