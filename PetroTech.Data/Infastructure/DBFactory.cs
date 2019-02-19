using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Data.Infastructure
{
    public class DBFactory : Disposable, IDBFactory
    {
        PetroDbContext petroDbContext;

        public PetroDbContext Init()
        {
            return petroDbContext ?? (petroDbContext = new PetroDbContext());
        }

        protected override void DisposeCore()
        {
            if (petroDbContext != null)
                petroDbContext.Dispose();
        }
    }
}
