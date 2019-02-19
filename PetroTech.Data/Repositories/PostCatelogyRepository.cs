using PetroTech.Data.Infastructure;
using PetroTech.Data.IRepositories;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public class PostCatelogyRepository : Repository<Footer>, IPostCatelogyRepository
    {
        public PostCatelogyRepository(IDBFactory dBFactory) : base(dBFactory)
        {
        }
    }
}