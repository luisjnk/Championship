using System;


namespace Championship.Domain.Entities
{
    public class Team
    {
        public Guid TeamId { get; set; }

        public string Name { get; set; }

        //public List<Player> Players { get; set; }

        public void genId() {
            this.TeamId = Guid.NewGuid();
        }

      /* public bool addPlayer(Player player)
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
        }*/

    }
}
