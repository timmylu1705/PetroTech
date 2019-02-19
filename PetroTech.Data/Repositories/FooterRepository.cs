using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public interface IFooterRepository
    {
    }

    public class FooterRepository : Repository<Footer>, IFooterRepository
    {
        public FooterRepository(IDBFactory dBFactory) : base(dBFactory)
        {

        }
    }
}