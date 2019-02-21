using PetroTech.Common.Resource;
using PetroTech.Data.Infastructure;
using PetroTech.Data.IRepositories;
using PetroTech.Model.Models;
using PetroTech.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PetroTech.Common.Resource.EnumTools;
using static PetroTech.Common.Resource.Helper.Enum;

namespace PetroTech.Service.Services
{
    public class PostService : IPostService
    {
        #region Fields
        IPostRepository _postRepo;
        IUnitOfWork _unitofwork;
        #endregion

        #region Constructor          
        public PostService(
            IPostRepository postRepo,
            IUnitOfWork unitofwork)
        {
            this._postRepo = postRepo;
            this._unitofwork = unitofwork;
        }
        #endregion

        #region Method
        public void AddPost(Post model)
        {
            _postRepo.Add(model);
        }

        public void DeletePost(string id)
        {
            _postRepo.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepo.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByCategory(string category, int page, int pageSize, out int totalRow)
        {
            return _postRepo.GetMultiPaging(x => x.Status == "A" && x.PostCatelogyID == category,
                out totalRow, page, pageSize, new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllPaging(int page, int pagesize, out int totalRow)
        {
            Status status = Status.A;

            return _postRepo.GetMultiPaging(x => x.Status == status.GetDescription(), out totalRow, page, pagesize);
        }

        public IEnumerable<Post> GetAllTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _postRepo.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        public Post GetByStringId(string id)
        {
            return _postRepo.GetSingleByStringId(id);
        }

        public void SaveChanges()
        {
            _unitofwork.Commit();
        }

        public void UpdatePost(Post model)
        {
            _postRepo.Update(model);
        }
        #endregion
    }
}
