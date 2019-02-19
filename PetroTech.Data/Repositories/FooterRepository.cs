using PetroTech.Data.Infastructure;
using PetroTech.Data.IRepositories;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public class FooterRepository : Repository<Footer>, IFooterRepository
    {
        public FooterRepository(IDBFactory dBFactory) : base(dBFactory)
        {

        }
    }
}