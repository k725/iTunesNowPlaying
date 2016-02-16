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

namespace iTunesNowPlaying
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            label.Content = this.getSong();
        }

        private void Get_Click(object sender, RoutedEventArgs e)
        {
            
            label.Content = this.getSong();
        }

        private string getSong()
        {
            var name = iTunesLibrary.Library.CurrentSong.Name;
            var album = iTunesLibrary.Library.CurrentSong.Album.Name;
            var artist = iTunesLibrary.Library.CurrentSong.Artist.Name;
            var track = iTunesLibrary.Library.CurrentSong.TrackNum;
            var disc = iTunesLibrary.Library.CurrentSong.Disc;

            return $"Disc :: {disc}\nTrack :: {track}\nName :: {name}\nAlbum :: {album}\nArtist :: {artist}";
        }
    }
}
