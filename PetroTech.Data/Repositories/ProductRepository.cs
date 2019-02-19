using PetroTech.Data.Infastructure;
using PetroTech.Data.IRepositories;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(IDBFactory dBFactory) : base(dBFactory)
        {
        }
    }
}