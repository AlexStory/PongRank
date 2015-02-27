using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongRank {
  public class Player {
    public int PlayerId { get; set; }
    public string Name { get; private set; }
    public int ELO { get; private set; }
    public int Wins { get; private set; }
    public int Losses { get; private set; }

    public Player() {  }

    public Player(string name) {
      this.Name = name;
      this.ELO = 1200;
      this.Wins = 0;
      this.Losses = 0;
    }

    public void AddWin() {
      this.Wins += 1;
    }

    public void AddLoss() {
      this.Losses += 1;
    }

    public void CalcElo(string result, int elo) {
      if (elo == this.ELO) {
        if (result == "win") {
          this.ELO = this.ELO + this.ELO / 20;
        } else {
          this.ELO = this.ELO - this.ELO / 20;
        }
      } else if (elo > this.ELO) {
        if (result == "win") {
          int diff = elo - this.ELO;
          if (diff > 60) {
            this.ELO = this.ELO + diff / 3;
          } else { this.ELO = this.ELO + 20; }
        } else {
          int diff = elo - this.ELO;
          if (diff > 60) {
            this.ELO = this.ELO - diff / 3;
          } else { this.ELO = this.ELO - 20; }
        }
      } else if (elo < this.ELO) {
        if (result == "win") {
          int diff = elo - this.ELO;
          if (diff > 60) {
            this.ELO = this.ELO + diff / 6;
          } else { this.ELO = this.ELO + 10; }
        } else {
          int diff = elo - this.ELO;
          if (diff > 60) {
            this.ELO = this.ELO - diff / 6;
          } else { this.ELO = this.ELO - 10; }
        }
      }
    }


  }
}
