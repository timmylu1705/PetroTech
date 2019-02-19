using PetroTech.Data.Infastructure;
using PetroTech.Data.IRepositories;
using PetroTech.Model.Models;
using PetroTech.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Service.Services
{
    public class PostService : IPostService
    {
        IPostRepository _postRepo;
        IUnitOfWork _unitofwork;

        public PostService(
            IPostRepository postRepo, 
            IUnitOfWork unitofwork)
        {
            this._postRepo = postRepo;
            this._unitofwork = unitofwork;
        }

        public void AddPost(Post model)
        {
            throw new NotImplementedException();
        }

        public void DeletePost(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAllPaging(int page, int pagesize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAllTagPaging(int page, int pagesize, out int totalRo)
        {
            throw new NotImplementedException();
        }

        public Post GetByStringId(string id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePost(Post model)
        {
            throw new NotImplementedException();
        }
    }
}
