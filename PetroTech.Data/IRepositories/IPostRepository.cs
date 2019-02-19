using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;
using System.Collections.Generic;

namespace PetroTech.Data.IRepositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }
}