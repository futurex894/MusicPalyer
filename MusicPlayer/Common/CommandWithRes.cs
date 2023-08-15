using System;
using System.Windows.Input;

namespace MusicPlayer.Common
{
    public class CommandWithRes<T> : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public CommandWithRes(Action<T> func) 
        {
            this.func =func;
        }

        Action<T> func;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (func != null && parameter!=null)
            {
                func((T)parameter);
            }
        }
    }
}
