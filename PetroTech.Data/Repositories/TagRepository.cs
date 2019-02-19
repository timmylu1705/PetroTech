using PetroTech.Data.Infastructure;
using PetroTech.Data.IRepositories;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(IDBFactory dBFactory) : base(dBFactory)
        {

        }
    }
}
