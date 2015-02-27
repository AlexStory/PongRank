using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongRank.Repository {
  interface IPongRepository {

     void AddPlayer(Player p);
     void AddGame(Game G);
  }
}
