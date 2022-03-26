using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DataAccess.Infrasturcture
{
  public  interface  IGenericRepository<T> where T :class
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);
        void Insert(T enetity);
        void Delete(T enetity);

        void DeleteRange(IEnumerable<T> enetitie);
    }
}
