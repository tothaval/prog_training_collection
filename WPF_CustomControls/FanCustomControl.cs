﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_CustomControls
{

    public class FanCustomControl : Control
    {


        public bool FanOn
        {
            get { return (bool)GetValue(FanOnProperty); }
            set { SetValue(FanOnProperty, value); }
        }

        public static readonly DependencyProperty FanOnProperty =
            DependencyProperty.Register("FanOn", typeof(bool), typeof(FanCustomControl), new PropertyMetadata(false));



        static FanCustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FanCustomControl), new FrameworkPropertyMetadata(typeof(FanCustomControl)));
        }
    }
}
