using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public interface IPostCatelogyRepository
    {
    }

    public class PostCatelogyRepository : Repository<Footer>, IPostCatelogyRepository
    {
        public PostCatelogyRepository(IDBFactory dBFactory) : base(dBFactory)
        {
        }
    }
}