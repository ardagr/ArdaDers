using System.Collections.Generic;

namespace DersProje.Models.Entity
{
    public class Ders
    {
        public int DersId { get; set; }
        public string DersAdi { get; set; }
        public string DersOgretmeni { get; set; }
        public int Kredi { get; set; }
        public int Donemi { get; set; }
        public List<OgrenciDers> OgrenciDers { get; set; }
    }



}
