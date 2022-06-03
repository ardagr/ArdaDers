using OtobusBileti.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti.Data.Abstract
{
   public interface IYolcuRepository: IRepository<Yolcu>
    {
       
        public List<Yolcu> DoluKoltuklariGetir(string Nereden, string Nereye, string Tarih, int Fiyat, string Saat, int YolId);
        public void CreateYolcu(Yolcu yolcu);
       
    }


}
