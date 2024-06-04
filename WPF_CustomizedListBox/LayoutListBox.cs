using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF_CustomizedListBox
{
    public class LayoutListBox : ListBox
    {



        public Layout layout
        {
            get { return (Layout)GetValue(layoutProperty); }
            set { SetValue(layoutProperty, value); }
        }

        // Using a DependencyProperty as the backing store for layout.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty layoutProperty =
            DependencyProperty.Register("layout", typeof(Layout), typeof(LayoutListBox), new PropertyMetadata(Layout.List));



        public enum Layout
        {
            Tile,
            List
        }
    }
}
