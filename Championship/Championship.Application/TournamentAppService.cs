using Championship.Application.Interfaces;
using Championship.Domain.Entities;
using Championship.Domain.Interfaces.Services;

namespace Championship.Application
{
    public class TournamentAppService : AppServiceBase<Tournament>, ITournamentAppService
    {
        public readonly ITournamenteService _tournamentSerivce;

        public TournamentAppService(ITournamenteService tournamentSerivce)
            : base(tournamentSerivce)
        {
            _tournamentSerivce = tournamentSerivce;
        }

        public void Generate(Tournament obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
