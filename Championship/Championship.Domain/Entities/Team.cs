using System;
using System.Collections.Generic;
using System.Text;

namespace Championship.Domain.Entities
{
    public class Team
    {
        public int TeamId { get; set; }

        public string Name { get; set; }

        public List<Player> Players { get; set; }

        public void genId() {
            Random rnd = new Random();
            this.TeamId = rnd.Next(1, 100);
        }

        public bool addPlayer(Player player)
        {
            bool containsItem = this.Players.Exists(t => t.PlayerId == player.PlayerId);
            if (containsItem)
            {
                return false;
            }
            else
            {
                this.Players.Add(player);
                return true;
            }
        }

    }
}
