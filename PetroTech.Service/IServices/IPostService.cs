using PetroTech.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Service.IServices
{
    public interface IPostService
    {
        void AddPost(Post model);

        void UpdatePost(Post model);

        void DeletePost(string id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pagesize, out int totalRow);

        Post GetByStringId(string id);

        IEnumerable<Post> GetAllTagPaging(int page, int pagesize, out int totalRo);
    }
}
