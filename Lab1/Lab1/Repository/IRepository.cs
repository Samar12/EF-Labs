using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{

    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(params object[] id);
        TEntity Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);

    }
}
