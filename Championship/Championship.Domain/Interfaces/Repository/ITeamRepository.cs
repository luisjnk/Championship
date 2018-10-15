using Championship.Domain.Entities;
using System.Collections.Generic;

namespace Championship.Domain.Interfaces
{
    public interface ITeamRepository : IRepositoryBase<Team>
    {
        IEnumerable<Team> SearchByName(string name);
    }
}
