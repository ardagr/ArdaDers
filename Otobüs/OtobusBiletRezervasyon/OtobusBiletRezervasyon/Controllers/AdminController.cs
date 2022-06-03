using Microsoft.AspNetCore.Mvc;
using OtobusBileti.Business.Abstract;
using OtobusBileti.Data;
using OtobusBileti.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtobusBiletRezervasyon.Controllers
{
    public class AdminController : Controller
    {
        private IYolcuService _yolcuService;
        private ISehirService _sehirService;
        private IYolService _yolService;

        public AdminController(IYolcuService yolcuService, ISehirService sehirService, IYolService yolService)
        {
            _yolcuService = yolcuService;
            _sehirService = sehirService;
            _yolService = yolService;
        }

        public IActionResult Index(string mesaj)
        {
            if (mesaj!=null)
            {
                return View(mesaj);
            }
                return View();

        }
        public IActionResult Giris(string kullaniciAd ,string kullaniciSifre)
        {
            if (kullaniciAd=="admin"&&kullaniciSifre=="admin123")
            {
                return RedirectToAction("Biletler");
            }
            else
            {
                string mesaj = "HATALI KULLANICI ADI VEYA ŞİFRE";
                return View("Index", mesaj);
            }

        }
        public IActionResult Biletler()
        {
           var biletler= _yolcuService.GetAll();// Bunu tamamlama
                return View(biletler);
        }
        public IActionResult YolcuSil(int id)
        {
           var silinecekYolcu= _yolcuService.GetById(id);
            _yolcuService.Delete(silinecekYolcu);
            
            return RedirectToAction("Biletler");
        }
        public IActionResult SehirEkle()
        {
            
            return View(_sehirService.GetAll());
        }

        [HttpPost]
        public IActionResult SehirEkle(string sehir)
        {
            Sehir model = new Sehir()
            {
                SehirAd = sehir
            };
            _sehirService.Create(model);
            return RedirectToAction("SehirEkle");
        }
        public IActionResult SehirSil(int id)
        {
           var silinecekSehir= _sehirService.GetById(id);
            _sehirService.Delete(silinecekSehir);


            return RedirectToAction("SehirEkle");

        }
        public IActionResult SeferEkle()
        {
            return View(_yolService.GetAll());
        }
         
        public IActionResult SeferSil(int id)
        {
            var silinecekSefer = _yolService.GetById(id);
            _yolService.Delete(silinecekSefer);
            return RedirectToAction("SeferEkle");
        }
        [HttpPost]
        public IActionResult SeferEkle(string nereden,string nereye,string tarih,int fiyat,string saat)
        {
            Yol sefer = new Yol()
            {
                 Nereden=nereden,
                 Nereye=nereye,
                 Tarih=tarih,
                 Fiyat=fiyat,
                 Saat=saat

            };
            _yolService.Create(sefer);
            return RedirectToAction("SeferEkle");
        }
    }
}
