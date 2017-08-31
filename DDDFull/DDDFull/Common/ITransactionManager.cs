using System;
using System.Collections.Generic;
using System.Text;

namespace DDDFull.Common
{
    interface ITransactionManager : IDisposable
    {
        IDisposable BeginTransaction();
        void Commit();
        void Rollback();
    }
}
