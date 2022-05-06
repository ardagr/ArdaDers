using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersProje.Models.Entity
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public int OgrenciNo { get; set; }
        public string OgrenciIsmi { get; set; }
        public string OgrenciSoyad { get; set; }
        public int OgrenciBolumId { get; set; }
        public Bolum Bolum { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime KayitTarihi { get; set; }
        public int Donemi { get; set; }
        public List<OgrenciDers> OgrenciDers { get; set; }





    }



}
