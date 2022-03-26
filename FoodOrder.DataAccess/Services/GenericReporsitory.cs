using FoodOrder.DataAccess.Infrasturcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DataAccess.Services
{
    public class GenericReporsitory<T> : IGenericRepository<T> where T : class
    {
        public void Delete(T enetity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<T> enetitie)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null, string Includeproperties = null)
        {
            throw new NotImplementedException();
        }

        public T GetById(Expression<Func<T, bool>> predicate = null, string Includeproperties = null)
        {
            throw new NotImplementedException();
        }

        public void Insert(T enetity)
        {
            throw new NotImplementedException();
        }
    }


}
