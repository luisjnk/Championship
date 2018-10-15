using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Championship.Domain.Entities;

namespace Championship.Tests
{
    [TestClass]
    public class PotTests
    {
        [TestMethod]
        public void CreatePOT()
        {
            //Arange
            Team firstTeam = new Team();
            firstTeam.Name = "First Team";
            firstTeam.genId();

            //ACT       
            Team secondTeam = new Team();
            secondTeam.Name = "Second Team";
            secondTeam.genId();

            Pot firstPot = new Pot();
            firstPot.genId();
            firstPot.addTeam(firstTeam);
            firstPot.addTeam(secondTeam);

            //Assert
            Assert.AreEqual(firstPot.teams[0], firstTeam);
            Assert.AreEqual(firstPot.teams[1], secondTeam);     
        }
        
    }
}
