using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NavigationDrawerControl
{
    public class NavigationDrawerItem : RadioButton
    {
        static NavigationDrawerItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NavigationDrawerItem), new FrameworkPropertyMetadata(typeof(NavigationDrawerItem)));
        }
    }
}
