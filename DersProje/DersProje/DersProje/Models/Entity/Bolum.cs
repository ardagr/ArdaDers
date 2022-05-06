namespace DersProje.Models.Entity
{
    public class Bolum
    {
        public int BolumId { get; set; }
        public string BolumAd { get; set; }
        public string BolumBaskani { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }
    }



}
