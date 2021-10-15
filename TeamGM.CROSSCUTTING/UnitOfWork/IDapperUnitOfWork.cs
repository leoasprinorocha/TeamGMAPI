using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamGM.CROSSCUTTING.UnitOfWork
{
    public interface IDapperUnitOfWork
    {
        public DbSession Session { get; }

        void BeginTransaction();

        void Commit();

        void Rollback();
    }
}
