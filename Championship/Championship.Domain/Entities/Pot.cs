using System;
using System.Collections.Generic;

namespace Championship.Domain.Entities
{
    public class Pot
    {
        public int potId { get; set; }

        public List<Team> teams { get; set; }

        public Pot()
        {
            this.teams = new List<Team>();
        }

        public bool addTeam(Team team)
        {
            bool containsItem = this.teams.Exists(t => t.TeamId == team.TeamId);
            if (containsItem)
            {
                return false;
            }
            else
            {
                this.teams.Add(team);
                return true;
            }
        }

        public void genId()
        {
            Random rnd = new Random();
            this.potId = rnd.Next(1, 100);
        }

        public List<Team> getTeams()
        {
            return this.teams;
        }
    }
}
