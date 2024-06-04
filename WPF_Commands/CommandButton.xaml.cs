using System;
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

namespace WPF_Commands
{
    /// <summary>
    /// Interaktionslogik für CommandButton.xaml
    /// </summary>
    public partial class CommandButton : UserControl, ICommandSource, IDisposable
    {
        public CommandButton()
        {
            InitializeComponent();

            MouseLeftButtonDown += CommandButton_MouseLeftButtonDown;
        }

        private void CommandButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Command != null)
            {
                if (Command.CanExecute(CommandParameter))
                {
                    Command.Execute(CommandParameter);
                }
            }
        }

        public void Dispose()
        {
            MouseLeftButtonDown -= CommandButton_MouseLeftButtonDown;
        }

        public ICommand Command { get; set; }

        public object CommandParameter { get; set; }

        public IInputElement CommandTarget { get; set; }
    }
}
