using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RoomReservation_MVVM.Commands
{
    public abstract class AsyncCommandBase : CommandBase
    {
        private bool isExecuting;

        private bool IsExecuting
        {
            get { return isExecuting; }
            set { isExecuting = value;
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return !IsExecuting && base.CanExecute(parameter);
        }


        public override async void Execute(object? parameter)
        {
            IsExecuting = true;

            try
            {
                await ExecuteAsync(parameter);
            }
            catch (Exception)
            {
                IsExecuting = false;
            }
        }

        public abstract Task ExecuteAsync(object? parameter);
    }
}
