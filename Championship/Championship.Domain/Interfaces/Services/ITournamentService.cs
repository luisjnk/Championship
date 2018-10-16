using Championship.Domain.Entities;

namespace Championship.Domain.Interfaces.Services
{
    public interface ITournamenteService :IServiceBase<Tournament>
    {
        void Generate(Tournament obj);
    }
}
