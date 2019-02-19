using PetroTech.Data.Infastructure;
using PetroTech.Data.IRepositories;
using PetroTech.Model.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PetroTech.Data.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(IDBFactory dBFactory) : base(dBFactory)
        {

        }
        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in PetroDbContext.Posts
                        join pt in PetroDbContext.PostTags
                        on p.PostID equals pt.PostID
                        where pt.TagID == tag && p.Status == "A"
                        orderby p.CreateDateTime descending
                        select p;

            totalRow = query.Count();

            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return query;
        }
    }
}