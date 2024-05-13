﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Trial2
{
    internal class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Action<object> _executeAction;
        private Func<object, bool> _canExecuteAction;


        public bool CanExecute(object? parameter)
        {
            if (_canExecuteAction == null) 
            {
                return true;
            }

            return _canExecuteAction.Invoke(parameter);
        }

        public void Execute(object? parameter)
        {
            _executeAction?.Invoke(parameter);
        }

        public RelayCommand(Action<object> executeAction, Func<object, bool> canExecuteAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        }
    }
}
