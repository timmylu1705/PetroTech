using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public interface ISildeRepository
    {
    }

    public class SildeRepository : Repository<Silde>, ISildeRepository
    {
        public SildeRepository(IDBFactory dBFactory) : base(dBFactory)
        {

        }
    }
}
