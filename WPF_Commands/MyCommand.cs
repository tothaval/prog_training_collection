using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Commands
{
    static class MyCommand
    {
        public static RoutedUICommand Hello { get; set; }

        static MyCommand()
        {
            InputGestureCollection inputGestureCollection = new InputGestureCollection();
            KeyGesture shortkey = new KeyGesture(Key.E, ModifierKeys.Control);

            inputGestureCollection.Add(shortkey);

            Hello = new RoutedUICommand("Hi", "Hello", typeof(MyCommand), inputGestureCollection);  
        }
    }
}
