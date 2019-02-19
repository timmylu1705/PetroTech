using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace PetroTech.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCatelogy>
    {
        IEnumerable<ProductCatelogy> GetByAlias(string alias);
    }
}