using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PongRank.Repository {
  public class PongRepository :IPongRepository {
    private PongContext _dbContext;

    public PongRepository() {
      _dbContext = new PongContext();
      _dbContext.Players.Load();
      _dbContext.Games.Load();
    }

    public IEnumerable<string> Names() {
      var query = from Player in _dbContext.Players
                  select Player.Name;
      var PlayerNames = query.ToList<string>();
      return PlayerNames;
    }
    

    public IEnumerable<Player> PlayerContext() {
      return _dbContext.Players.Local;
    }

    public IEnumerable<Game> GameContext() {
      return _dbContext.Games.Local;
    }

    public IEnumerable<Player> ALL() {
      var query = from Player in _dbContext.Players
                  select Player;
      return query.ToList<Player>();
    }

    public void AddPlayer(Player p) {
      foreach (Player player in _dbContext.Players) {
        if (p.Name == player.Name) { throw new ArgumentException("No Duplicate Names"); } 
      }
      _dbContext.Players.Add(p);
      _dbContext.SaveChanges();
    }

    public void AddGame(string w, string l) {
      var win = from Player in _dbContext.Players
                    where Player.Name == w
                    select Player;
      var lose = from Player in _dbContext.Players
                    where Player.Name == l
                    select Player;
        Game g = new Game(win.First<Player>(), lose.First<Player>());
        _dbContext.Games.Add(g);
        _dbContext.SaveChanges();
    }
  }
}
