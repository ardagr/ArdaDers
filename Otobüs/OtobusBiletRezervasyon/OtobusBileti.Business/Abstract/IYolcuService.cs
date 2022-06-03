using OtobusBileti.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti.Business.Abstract
{
   public interface IYolcuService
    {
        void Create(Yolcu entity); //(C)REATE
        void CreateYolcu(Yolcu yolcu);
        List<Yolcu> GetAll();      //(R)EAD 
        Yolcu GetById(int id);
        void Update(Yolcu entity);  //(U)PDATE
        void Delete(Yolcu entity);  //(D)ELETE
        List<Yolcu> DoluKoltuklariGetir(string Nereden, string Nereye, string Tarih, int Fiyat, string Saat, int YolId);
    }
}
