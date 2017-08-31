using System;
using System.Collections.Generic;
using System.Text;

namespace DDDFull.Common
{
    interface IUnitOfWork : ITransactionManager
    {
        TRepository GetRepository<TRepository>();
    }
}