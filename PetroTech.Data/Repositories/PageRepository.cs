using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public interface IPageRepository
    {
    }

    public class PageRepository : Repository<Page>, IPageRepository
    {
        public PageRepository(IDBFactory dBFactory) : base(dBFactory)
        {
        }
    }
}