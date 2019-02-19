using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public interface IMenuRepository
    {
    }

    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        public MenuRepository(IDBFactory dBFactory) : base(dBFactory)
        {
        }
    }
}