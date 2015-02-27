using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PongRank;

namespace TestPongRank {
  [TestClass]
  public class PongUnitTests {
    [TestMethod]
    public void CreatePlayer() {
      var player = new Player("Alex");
      Assert.AreEqual("Alex", player.Name);
      Assert.AreEqual(1200, player.ELO);
      Assert.AreEqual(0, player.Wins);
      Assert.AreEqual(0, player.Losses);
    }

    [TestMethod]
    public void WinEvenGame() {
      var alex = new Player("Alex");
      var adam = new Player("Adam");

      alex.CalcElo("win", adam.ELO);
      Assert.AreEqual(1260, alex.ELO);
    }

    [TestMethod]
    public void TestAddWin() {
      var alex = new Player("Alex");
      alex.AddWin();
      Assert.AreEqual(alex.Wins, 1);
      
    }

    [TestMethod]
    public void TestAddLoss() {
      var adam = new Player("Adam");
      adam.AddLoss();
      Assert.AreEqual(1, adam.Losses);
    }
  }
}
