  using OtobusBileti.Data.Abstract;
using OtobusBileti.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti.Data.Concrete.EfCore
{
    public class EfCoreSehirRepository : EfCoreGenericRepository<Sehir, OtobusContext>, ISehirRepository
    {
       
    }
}
