using Microsoft.EntityFrameworkCore;
using OtobusBileti.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti.Data.Concrete.EfCore
{
   public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new OtobusContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {

                if (context.Yolcular.Count() == 0)
                {
                    context.Yolcular.AddRange(Yolcular);
                }
                if (context.Yollar.Count() == 0) 
                {
                    context.Yollar.AddRange(Yollar);

                }
                if (context.Sehirler.Count() == 0)
                {
                    context.Sehirler.AddRange(Sehirler);
                }
            }
            context.SaveChanges();
        }
        private static Yol[] Yollar =
        {
            new Yol() {YolId=1, Nereden="İstanbul" ,Nereye="Kocaeli", Tarih="15.05.2022",Saat="10.00"},
            new Yol() {YolId=2, Nereden="KOCAELİ" ,Nereye="İSTANBUL", Tarih="15.05.2022",Saat="10.00"},
            new Yol() {YolId=3,Nereden="ADANA" ,Nereye="ANKARA", Tarih="15.05.2022",Saat="10.00"},
            new Yol() {YolId=4,Nereden="İSTANBUL" ,Nereye="ADIYAMAN", Tarih="15.05.2022",Saat="10.00"},
            new Yol() {YolId=5,Nereden="ANKARA" ,Nereye="TRABZON", Tarih="15.05.2022",Saat="10.00"}
            
        };
        private static Yolcu[] Yolcular =
        {
            new Yolcu() {YolcuId=1, Ad="Arda",Soyad="GİRİSİT",Nereden="İSTANBUL",Nereye="KOCAELİ",KoltukNo=1,Fiyat=150,YolId=1},
            new Yolcu() {YolcuId=2,Ad="EDA",Soyad="GİRİSİT",Nereden="KOCAELİ" ,Nereye="İSTANBUL",KoltukNo=2,Fiyat=150,YolId=2},
            new Yolcu() {YolcuId=3,Ad="ELA",Soyad="GİRİSİT",Nereden="ADANA" ,Nereye="ANKARA",KoltukNo=3,Fiyat=150,YolId=3},
            new Yolcu() {YolcuId=4,Ad="SEDA",Soyad="GİRİSİT",Nereden="İSTANBUL" ,Nereye="ADIYAMAN",KoltukNo=4,Fiyat=150,YolId=4},
            new Yolcu() {YolcuId=5,Ad="Sifa",Soyad="GİRİSİT",Nereden="ANKARA" ,Nereye="TRABZON",KoltukNo=5,Fiyat=150,YolId=5}
           

        };
        private static Sehir[] Sehirler =
        {
            new Sehir() {SehirId=1, SehirAd="İSTANBUL"},
            new Sehir() {SehirId=2,SehirAd="KOCAELİ"},
            new Sehir() {SehirId=3,SehirAd="ADANA"},
            new Sehir() {SehirId=4,SehirAd="ANKARA"},
            new Sehir() {SehirId=5,SehirAd="SAKARYA"},
         
        };

    }
}
