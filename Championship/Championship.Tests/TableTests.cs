using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Championship.Domain.Entities;
using Championship.Domain.Models;
using System.Collections.Generic;

namespace Championship.Tests
{
    [TestClass]
    public class TableTests
    {
        [TestMethod]
        public void IncreaseWinnerScoreAndSecondPlaceIsTheNewFirst()
        {
            //Arange
            Team firstTeam = new Team();
            firstTeam.Name = "First Team";

            //ACT       
            Team secondTeam = new Team();
            secondTeam.Name = "Second Team";

            Table table = new Table();
            Place firstPlace = new Place();
            firstPlace.Name = "First Team";
            firstPlace.Score = 3;

            Place secondPlace = new Place();
            firstPlace.Name = "Second Team";
            firstPlace.Score = 1;
            table.places = new List<Place>();
            table.places.Add(firstPlace);
            table.places.Add(secondPlace);
            
            table.IncreaseWinnerScore(secondTeam);

            //Assert
            Assert.AreEqual(table.places[0].Score, 4);
            Assert.AreEqual(table.places[0].Name, "Second Team");
        }

    }
}
