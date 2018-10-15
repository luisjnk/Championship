using Championship.Domain.Entities;
using System.Collections.Generic;

namespace Championship.Domain.Interfaces
{
    public interface IPlayerRepository : IRepositoryBase<Player>
    {
        IEnumerable<Team> SearchByName(string name);

    }
}
