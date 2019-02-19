using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public interface IMenuGroupRepository
    {
    }

    public class MenuGroupRepository : Repository<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDBFactory dBFactory) : base(dBFactory)
        {
        }
    }
}