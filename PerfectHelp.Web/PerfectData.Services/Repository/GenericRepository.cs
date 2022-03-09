using Microsoft.EntityFrameworkCore;
using PerfectHelp.Data;
using System.Linq.Expressions;

namespace PerfectData.Services.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;
        
        public GenericRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> expression)
        {
            return this.dbContext.Set<T>().Where(expression).AsNoTracking()
                .ToList();
        }
        public IEnumerable<T> FindAll(Expression<Func<T, bool>> expression, int page = 1)
        {
            return this.dbContext.Set<T>().Where(expression).AsNoTracking()
                .Skip((page-1) * 20)
                .Take(20)
                .ToList();
        }
        public T? GetById(object id)
        {
            var entity = this.dbContext.Set<T>().FindAsync(id).Result;
            return entity;
        }
        public void Insert(T obj)
        {
            this.dbContext.Set<T>().Add(obj);
            this.dbContext.SaveChanges();
        }
        public void Update(T entity)
        {
            this.dbContext.Set<T>().Update(entity);
            this.dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            this.dbContext.Set<T>().Remove(entity);
            this.dbContext.SaveChanges();
        }
    }
}
