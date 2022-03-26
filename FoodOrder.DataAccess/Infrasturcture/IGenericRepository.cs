using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DataAccess.Infrasturcture
{
  public  interface  IGenericRepository<T> where T :class
    {
        IEnumerable<T> GetAll(Expression<Func<T , bool>>? predicate =null , string? Includeproperties = null );
        T GetById(Expression<Func<T, bool>>? predicate = null, string? Includeproperties = null);
        void Insert(T enetity);
        void Delete(T enetity);

        void DeleteRange(IEnumerable<T> enetitie);
    }
}
