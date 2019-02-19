using PetroTech.Data.Infastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Data.Repositories
{
    public abstract class Repository<T> where T : class
    {
        #region Properties

        private RetroDbContext retroDbContext;

        private readonly IDbSet<T> dbSet;

        protected IDBFactory DBFactory
        {
            get;
            private set;
        }

        protected RetroDbContext RetroDbContext
        {
            get { return retroDbContext ?? (retroDbContext = DBFactory.Init()); }
        }

        #endregion

        protected Repository(IDBFactory dBFactory)
        {
            DBFactory = DBFactory;
            dbSet = RetroDbContext.Set<T>();
        }

        #region Implementation

        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            retroDbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void DeleteMulti(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        public virtual T GetSingleByIntId(int id)
        {
            return dbSet.Find(id);
        }

        public virtual T GetSingleByStringId(string id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where, string includes)
        {
            return dbSet.Where(where).ToList();
        }

        public virtual int Count(Expression<Func<T, bool>> where)
        {
            return dbSet.Count(where);
        }

        public IQueryable<T> GetAll(string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = retroDbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);

                return query.AsQueryable();
            }

            return retroDbContext.Set<T>().AsQueryable();
        }

        public T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            return GetAll(includes).FirstOrDefault(expression);
        }

        public virtual IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            if(includes != null && includes.Count() > 0)
            {
                var query = retroDbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);

                return query.Where<T>(predicate).AsQueryable<T>();
            }

            return retroDbContext.Set<T>().Where<T>(predicate).AsQueryable<T>();
        }

        public virtual IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> predicate, out int total, int index = 0, int size = 20, string[] includes = null)
        {
            int skipCount = index*size;
            IQueryable<T> _resetSet;

            if(includes != null && includes.Count() > 0)
            {
                var query = retroDbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);

                _resetSet = predicate != null ? query.Where<T>(predicate).AsQueryable() : query.AsQueryable();
            }
            else
            {
                _resetSet = predicate != null ? retroDbContext.Set<T>().Where<T>(predicate).AsQueryable() : retroDbContext.Set<T>().AsQueryable();
            }

            _resetSet = skipCount == 0 ? _resetSet.Take(size) : _resetSet.Skip(skipCount).Take(size);
            total = _resetSet.Count();
            return _resetSet.AsQueryable();
        }

        public bool CheckContains(Expression<Func<T, bool>> predicate)
        {
            return retroDbContext.Set<T>().Count<T>(predicate) > 0;
        }

        #endregion

    }
}
