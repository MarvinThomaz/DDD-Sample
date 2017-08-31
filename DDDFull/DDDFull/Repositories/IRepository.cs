using System;
using System.Collections.Generic;
using System.Text;

namespace DDDFull.Repositories
{
    interface IRepository<TEntity>
    {
        void Create(TEntity entity);
    }
}