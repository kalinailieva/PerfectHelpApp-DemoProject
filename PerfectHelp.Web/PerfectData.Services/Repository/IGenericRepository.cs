
using System.Linq.Expressions;

namespace PerfectData.Services.Repository
{
    public interface IGenericRepository<T> where T : class
    {
     IEnumerable<T> FindAll(Expression<Func<T, bool>> expression);
     IEnumerable<T> FindAll(Expression<Func<T, bool>> expression, int page = 1);

     T? GetById(object id);
     void Insert(T obj);

     void Update(T entity);

     void Delete(T entity);
    }
}
