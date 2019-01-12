using Abp.Domain.Entities;

namespace Abp.Dapper.Repositories
{
    //change  IEntity<long>
    public interface IDapperRepository<TEntity> : IDapperRepository<TEntity, int> where TEntity : class, IEntity<int>,IEntity<long>
    {
    }
}
