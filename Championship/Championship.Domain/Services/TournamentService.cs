
using System.Collections.Generic;
using System.Threading.Tasks;
using Championship.Domain.Entities;
using Championship.Domain.Interfaces;
using Championship.Domain.Interfaces.Services;

namespace Championship.Domain.Services
{
    public class TournamentService : ServiceBase<Tournament>, ITournamenteService
    {
        public readonly ITournamentRepository _tournamentRepository;

        public  TournamentService(ITournamentRepository tournamentRepository)
            :base(tournamentRepository)
        {
            _tournamentRepository = tournamentRepository;
        }
        public void Generate(Tournament obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
