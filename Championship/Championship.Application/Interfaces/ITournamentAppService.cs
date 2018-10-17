using Championship.Domain.Entities;

namespace Championship.Application.Interfaces
{
    public interface ITournamentAppService :IAppServiceBase<Tournament>
    {
        void Generate(Tournament obj); 
    }
}
