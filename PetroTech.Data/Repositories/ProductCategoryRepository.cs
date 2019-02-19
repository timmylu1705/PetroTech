using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCatelogy> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : Repository<ProductCatelogy>, IProductCategoryRepository
    {
        public ProductCategoryRepository(DBFactory dBFactory) : base(dBFactory) { }

        public IEnumerable<ProductCatelogy> GetByAlias(string alias)
        {
            return this.PetroDbContext.ProductCatelogies.Where(x => x.Alias == alias);
        }
    }
}
