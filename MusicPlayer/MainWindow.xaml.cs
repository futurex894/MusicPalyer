using MusicPlayer.ViewModel;
using System.Windows;

namespace MusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowVM();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        
    }
}
