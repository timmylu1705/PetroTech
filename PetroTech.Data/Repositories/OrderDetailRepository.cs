using PetroTech.Data.Infastructure;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public interface IOrderDetailRepostory
    {
    }

    public class OrderDetailRepository : Repository<OrderDetail>, IOrderRepository
    {
        public OrderDetailRepository(IDBFactory dBFactory) : base(dBFactory)
        {
        }
    }
}