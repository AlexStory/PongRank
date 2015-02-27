using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PongRank {
  public class PongContext : DbContext {
    public DbSet<Game> Games { get; set; }
    public DbSet<Player> Players { get; set; }
  }
}
