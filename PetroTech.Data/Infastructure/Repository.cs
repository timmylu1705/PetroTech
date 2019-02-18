using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Data.Infastructure
{
    public abstract class Repository<T> where T : class
    {
        #region Properties
        private RetroDbContext retroDbContext;
        private readonly IDbSet<T> dbSet;

        protected IDBFactory DBFactory
        {
            get;
            private set;
        }

        protected RetroDbContext RetroDbContext
        {
            get { return retroDbContext ?? (retroDbContext = DBFactory.Init()); }
        }
        #endregion

        protected Repository(IDBFactory dBFactory)
        {
            DBFactory = DBFactory;
            dbSet = RetroDbContext.Set<T>();
        }

    }
}
