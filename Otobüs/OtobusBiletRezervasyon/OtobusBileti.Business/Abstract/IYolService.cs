using OtobusBileti.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti.Business.Abstract
{
    public interface IYolService
    {
        void Create(Yol entity); //(C)REATE
        List<Yol> GetAll();      //(R)EAD
        Yol GetById(int id);
        void Update(Yol entity);  //(U)PDATE
        void Delete(Yol entity);  //(D)ELETE
        List<Yol> BiletleriGetir(Yol yol);
    }
}
