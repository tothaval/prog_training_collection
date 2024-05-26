﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Training6_Login.ViewModels
{
    public class LayoutViewModel : BaseViewModel
    {
        public NavigationBarViewModel NavigationBarViewModel { get; }
        public BaseViewModel ContentViewModel { get; }

        public LayoutViewModel(NavigationBarViewModel navigationBarViewModel, BaseViewModel contentViewModel)
        {
            NavigationBarViewModel = navigationBarViewModel;
            ContentViewModel = contentViewModel;
        }

        public override void Dispose()
        {
            NavigationBarViewModel.Dispose();
            ContentViewModel.Dispose();

            base.Dispose();
        }
    }
}