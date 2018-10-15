using Championship.Domain.Interfaces;
using Championship.Domain.Interfaces.Services;
using System;

namespace Championship.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj, string uri)
        {
            _repository.Add(obj, uri);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
