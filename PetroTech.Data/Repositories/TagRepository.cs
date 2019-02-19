using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public interface ITagRepository
    {
    }

    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(IDBFactory dBFactory) : base(dBFactory)
        {

        }
    }
}
