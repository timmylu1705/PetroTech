using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public interface IPostTagRepository
    {
    }

    public class PostTagRepository : Repository<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDBFactory dBFactory) : base(dBFactory)
        {

        }
    }
}
