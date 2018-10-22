using System;
using System.Collections.Generic;
using System.Linq;

namespace Championship.Domain.Entities
{
    public class Key
    {
        public Guid KeyId { get; set; }

        public string Name { get; set; }

        public List<Team> Teams {get; set;}

        private int _pointsOfWinner = 3;

        public void IncreaseWinnerScore(Team team)
        {
            Team TeamOnKey = Teams.FirstOrDefault(t => t.Name == team.Name);
            TeamOnKey.Score = TeamOnKey.Score + _pointsOfWinner;
            OrderByTable();
        }

        private void OrderByTable()
        {
            Teams.OrderBy(t => t.Score);
        }


    }
}