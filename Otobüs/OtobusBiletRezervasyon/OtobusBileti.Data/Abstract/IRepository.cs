using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti.Data.Abstract
{
   public interface IRepository<T>
    {
        void Create(T entity); //(C)REATE
        List<T> GetAll();      //(R)EAD
        T GetById(int id);
        void Update(T entity);  //(U)PDATE
        void Delete(T entity);  //(D)ELETE
       
    }
}
