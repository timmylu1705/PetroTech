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
        private PetroDbContext petroDbContext;

        public UnitOfWork(IDBFactory dBFactory)
        {
            this.dBFactory = dBFactory;
        }

        public PetroDbContext PetroDbContext
        {
            get { return petroDbContext ?? (petroDbContext = dBFactory.Init()); }
        }

        public void Commit()
        {
            PetroDbContext.SaveChanges();
        }
    }
}
