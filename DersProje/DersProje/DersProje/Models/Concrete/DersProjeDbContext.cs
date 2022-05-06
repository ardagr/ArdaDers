using DersProje.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersProje.Models.Concrete
{
    public class DersProjeDbContext: DbContext
    {
        public DersProjeDbContext()
        {

        }

        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=OgrenciDers");
            }
        }
    }
    

}
