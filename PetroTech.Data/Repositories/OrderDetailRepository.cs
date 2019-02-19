using System;
using System.Linq;
using System.Linq.Expressions;
using PetroTech.Data.Infastructure;
using PetroTech.Data.IRepositories;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderRepository
    {
        public OrderDetailRepository(IDBFactory dBFactory) : base(dBFactory)
        {
        }

        public void Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public bool CheckContains(Expression<Func<Order, bool>> predicatel)
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<Order, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteMulti(Expression<Func<Order, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetMulti(Expression<Func<Order, bool>> predicate, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetMultiPaging(Expression<Func<Order, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public Order GetSingleByCondition(Expression<Func<Order, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Order> IRepository<Order>.GetAll(string[] includes)
        {
            throw new NotImplementedException();
        }

        Order IRepository<Order>.GetSingleByIntId(int id)
        {
            throw new NotImplementedException();
        }

        Order IRepository<Order>.GetSingleByStringId(string id)
        {
            throw new NotImplementedException();
        }
    }
}