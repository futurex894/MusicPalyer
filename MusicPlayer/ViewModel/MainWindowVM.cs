using MusicPlayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace MusicPlayer.ViewModel
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand Message  {get; set; }
        public MainWindowVM() 
        {
            Message = new CommandWithRes<string>((str) =>
            {
                MessageBox.Show(str);
            });
        }
    }
}
