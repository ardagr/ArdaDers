using Microsoft.EntityFrameworkCore;
using OtobusBileti.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti.Data
{
   public class OtobusContext:DbContext
    {
        public DbSet<Yol> Yollar { get; set; }
        public DbSet<Yolcu> Yolcular { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=OtobusDb");
        }
    }
}
