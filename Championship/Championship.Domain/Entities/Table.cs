using System.Collections.Generic;
using System.Linq;

namespace Championship.Domain.Entities
{
    public class Table
    {
        public List<Place> places;

        public void IncreaseWinnerScore(Team team)
        {
            Place TeamOnPlace = places.FirstOrDefault(place => place.Name == team.Name);
            TeamOnPlace.Score = TeamOnPlace.Score  + 3;
            OrderByTable();
        }

        private void OrderByTable()
        {
           places.OrderBy(place => place.Score);
        }

    }
}
