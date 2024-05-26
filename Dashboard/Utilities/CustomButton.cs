using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Dashboard.Utilities
{
    public class CustomButton : RadioButton
    {
        static CustomButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomButton),
                new FrameworkPropertyMetadata(typeof(CustomButton)));
                
        }
    }
}
