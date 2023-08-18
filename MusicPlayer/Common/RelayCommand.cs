using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MusicPlayer.Common
{
    public class RelayCommand : ICommand
    {
        public RelayCommand(Action action) 
        {
            this.action = action;
        }
        public event EventHandler? CanExecuteChanged;
        Action action;
        public bool CanExecute(object? parameter)
        {
            return true;
        }
        public void Execute(object? parameter)
        {
            action();
        }
    }
}
