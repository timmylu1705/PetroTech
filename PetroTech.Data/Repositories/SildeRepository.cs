using PetroTech.Data.Infastructure;
using PetroTech.Data.IRepositories;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public class SildeRepository : Repository<Silde>, ISildeRepository
    {
        public SildeRepository(IDBFactory dBFactory) : base(dBFactory)
        {

        }
    }
}
