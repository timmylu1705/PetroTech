using System;
using System.Linq;
using System.Linq.Expressions;
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

        public void Add(PostCatelogy entity)
        {
            throw new NotImplementedException();
        }

        public bool CheckContains(Expression<Func<PostCatelogy, bool>> predicatel)
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<PostCatelogy, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Delete(PostCatelogy entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteMulti(Expression<Func<PostCatelogy, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PostCatelogy> GetMulti(Expression<Func<PostCatelogy, bool>> predicate, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PostCatelogy> GetMultiPaging(Expression<Func<PostCatelogy, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public PostCatelogy GetSingleByCondition(Expression<Func<PostCatelogy, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public void Update(PostCatelogy entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<PostCatelogy> IRepository<PostCatelogy>.GetAll(string[] includes)
        {
            throw new NotImplementedException();
        }

        PostCatelogy IRepository<PostCatelogy>.GetSingleByIntId(int id)
        {
            throw new NotImplementedException();
        }

        PostCatelogy IRepository<PostCatelogy>.GetSingleByStringId(string id)
        {
            throw new NotImplementedException();
        }
    }
}