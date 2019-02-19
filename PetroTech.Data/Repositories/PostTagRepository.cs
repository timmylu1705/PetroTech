using PetroTech.Data.Infastructure;
using PetroTech.Data.IRepositories;
using PetroTech.Model.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PetroTech.Data.Repositories
{
    public class PostTagRepository : Repository<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDBFactory dBFactory) : base(dBFactory)
        {

        }
    }
}
