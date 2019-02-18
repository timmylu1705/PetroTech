using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Data.Infastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDBFactory dBFactory;
        private RetroDbContext retroDbContext;

        public UnitOfWork(IDBFactory dBFactory)
        {
            this.dBFactory = dBFactory;
        }

        public RetroDbContext RetroDbContext
        {
            get { return retroDbContext ?? (retroDbContext = dBFactory.Init()); }
        }

        public void Commit()
        {
            RetroDbContext.SaveChanges();
        }
    }
}
