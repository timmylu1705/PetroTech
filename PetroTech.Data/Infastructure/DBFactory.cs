using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Data.Infastructure
{
    public class DBFactory : Disposable, IDBFactory
    {
        RetroDbContext retroDbContext;

        public RetroDbContext Init()
        {
            return retroDbContext ?? (retroDbContext = new RetroDbContext());
        }

        protected override void DisposeCore()
        {
            if (retroDbContext != null)
                retroDbContext.Dispose();
        }
    }
}
