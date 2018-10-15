
using Championship.Domain.Entities;
using Championship.Domain.Interfaces;
using Championship.Domain.Interfaces.Services;

namespace Championship.Domain.Services
{
    public class KeyService : ServiceBase<Key>, IKeyService
    {
        private readonly IkeyRepository _keyRepository;

        public KeyService(IkeyRepository keyrepository)
            :base(keyrepository)
        {
            _keyRepository = keyrepository;
        }

        public void Generate(Key obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
