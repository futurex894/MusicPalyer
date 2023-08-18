using MusicPlayer.Common;

namespace MusicPlayer.ViewModel
{
    public class MainWindowVM : NotifyPropertyChanged
    {
        public string show
        {
            get 
            {
                return "1";
            }
            set
            {
                PropertyChange(nameof(show));
            }
        }
        
    }
}
