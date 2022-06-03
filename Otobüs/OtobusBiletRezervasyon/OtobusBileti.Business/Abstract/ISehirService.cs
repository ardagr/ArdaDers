using OtobusBileti.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti.Business.Abstract
{
   
    public interface ISehirService
    {
        void Create(Sehir entity); //(C)REATE
        List<Sehir> GetAll();      //(R)EAD
        Sehir GetById(int id);
        void Update(Sehir entity);  //(U)PDATE
        void Delete(Sehir entity);  //(D)ELETE
        //public void SehirEkle(string sehir);
    }
}
