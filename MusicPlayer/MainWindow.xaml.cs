using MusicPlayer.ViewModel;
using System.Windows;
using System.Windows.Media.Animation;

namespace MusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool ok=false;
        bool ok2 = false;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowVM();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Storyboard storyboard = (Storyboard)FindResource("ImageRun");
            if (!ok)
            {
                ok = true;
                
                storyboard.Begin();
                ok2 = true;
            }
            else
            {
                if (!ok2)
                {
                    storyboard.Pause();
                    ok2 = true;
                }
                else
                {
                    storyboard.Resume();
                    ok2 = false;
                }
                
            }

        }

        
    }
}
