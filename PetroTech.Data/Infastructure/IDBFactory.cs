using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Data.Infastructure
{
    public interface IDBFactory : IDisposable
    {
        RetroDbContext Init();
    }
}
