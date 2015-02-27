using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongRank {
  public class Game {
    public int GameId { get; set; }
    public Player Winner { get; private set; }
    public Player Loser { get; private set; }

    public Game() { }


    public Game(Player winner, Player loser) {
      this.Winner = winner;
      this.Loser = loser;
      Winner.AddWin();
      Loser.AddLoss();
      Winner.CalcElo("win", Loser.ELO);
      Loser.CalcElo("loss", Winner.ELO);

    }
  }
}
