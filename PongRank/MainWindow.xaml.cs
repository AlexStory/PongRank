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
using PongRank.Repository;

namespace PongRank {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {

    public static PongRepository repo = new PongRepository();

    public MainWindow() {
      InitializeComponent();
      PlayerTable.DataContext = repo.PlayerContext();
      WinnerBox.DataContext = repo.PlayerContext();
      loser.DataContext = repo.PlayerContext();      

    }

    private void Button_Click(object sender, RoutedEventArgs e) {
      var player = new Player(NewPlayerName.Text);
      repo.AddPlayer(player);
    }

    private void add_game(object sender, RoutedEventArgs e) {
      var player = new Player(NewPlayerName.Text);
      repo.AddGame(WinnerBox.SelectedValue.ToString(), loser.SelectedValue.ToString());
    }
    

  }
}
