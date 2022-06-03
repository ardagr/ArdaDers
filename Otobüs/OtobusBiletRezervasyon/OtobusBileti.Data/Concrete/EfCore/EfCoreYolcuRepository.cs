using OtobusBileti.Data.Abstract;
using OtobusBileti.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti.Data.Concrete.EfCore
{
    public class EfCoreYolcuRepository : EfCoreGenericRepository<Yolcu, OtobusContext>, IYolcuRepository
    {
        public void CreateYolcu(Yolcu yolcu)
        {
            using (var context = new OtobusContext())
            {
             
                    context.Add(yolcu);
                    context.SaveChanges();
            }
        }

        public List<Yolcu> DoluKoltuklariGetir(string Nereden, string Nereye, string Tarih, int Fiyat, string Saat, int YolId)
        {
            using (var context = new OtobusContext())
            {
                var dolukoltuklar = context.Yolcular.Where(i => i.Nereden == Nereden && i.Nereye == Nereye && i.Tarih == Tarih && i.Saat == Saat).ToList();
                return dolukoltuklar;
            }
        }   

        
    }
}
