using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(IDBFactory dBFactory) : base(dBFactory)
        {
        }
    }
}