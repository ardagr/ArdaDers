using OtobusBileti.Data.Abstract;
using OtobusBileti.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti.Data.Concrete.EfCore
{
    public class EfCoreYolRepository : EfCoreGenericRepository<Yol, OtobusContext>, IYolRepository
    {
        public List<Yol> BiletleriGetir(Yol yolum)
        {
            using (var context=new OtobusContext())
            {
                var yol = context.Yollar.Where(i => i.Nereden == yolum.Nereden && i.Nereye==yolum.Nereye && i.Tarih==yolum.Tarih).ToList();
                return yol;
            }
        }
    }
}
