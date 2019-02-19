using PetroTech.Data.Infastructure;
using PetroTech.Data.IRepositories;
using PetroTech.Model.Models;
using PetroTech.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Service.Services
{
    public class PostCategoryService : IPostCategoryService
    {
        #region Property
        IPostCatelogyRepository _postCategoryRepo;
        IUnitOfWork _unitofwork;
        #endregion

        #region Constructor          
        public PostCategoryService(
            IPostCatelogyRepository postCategoryRepo,
            IUnitOfWork unitofwork)
        {
            this._postCategoryRepo = postCategoryRepo;
            this._unitofwork = unitofwork;
        }
        #endregion

        #region Constructor 
        public void Add(PostCatelogy entity)
        {
            _postCategoryRepo.Add(entity);
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
            _postCategoryRepo.Delete(entity);
        }

        public void Delete(int id)
        {
            _postCategoryRepo.Delete(id);
        }

        public void Delete(string id)
        {
            _postCategoryRepo.Delete(id);
        }

        public void DeleteMulti(Expression<Func<PostCatelogy, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PostCatelogy> GetAll(string[] includes = null)
        {
            return _postCategoryRepo.GetAll();
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

        public PostCatelogy GetSingleByIntId(int id)
        {
            return _postCategoryRepo.GetSingleByIntId(id);
        }

        public PostCatelogy GetSingleByStringId(string id)
        {
            return _postCategoryRepo.GetSingleByStringId(id);
        }

        public void Update(PostCatelogy entity)
        {
            _postCategoryRepo.Update(entity);
        }
        #endregion
    }
}
