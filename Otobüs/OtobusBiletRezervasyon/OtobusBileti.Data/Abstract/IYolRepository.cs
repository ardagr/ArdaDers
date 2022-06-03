using OtobusBileti.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti.Data.Abstract
{
   public interface IYolRepository:IRepository<Yol>
    {
        List<Yol> BiletleriGetir(Yol yol);
    }
}
