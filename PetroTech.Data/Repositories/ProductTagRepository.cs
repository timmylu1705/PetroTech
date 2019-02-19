using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public interface IProductTagRepository
    {
    }

    public class ProductTagRepository : Repository<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDBFactory dBFactory) : base(dBFactory)
        {

        }
    }
}
