using Projeto01.Domain.Contracts.Repositories;
using Projeto01.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Domain.Services
{
    public abstract class BaseDomainService<TEntity, Tkey> : IBaseDomainService<TEntity, Tkey>
        where TEntity : class
        where Tkey : struct
    {
        private readonly IBaseRepository<TEntity, Tkey> _repository;

        protected BaseDomainService(IBaseRepository<TEntity, Tkey> repository)
        {
            _repository = repository;
        }

        public virtual void Create(TEntity entity)
        {
            _repository.Create(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public virtual List<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual TEntity GetById(Tkey id)
        {
            return _repository.GetById(id);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
