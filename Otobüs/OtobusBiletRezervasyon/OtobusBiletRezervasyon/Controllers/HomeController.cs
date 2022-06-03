using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using OtobusBileti.Business.Abstract;
using OtobusBileti.Data;
using OtobusBileti.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OtobusBiletRezervasyon.Controllers
{
    public class HomeController : Controller
    {
        private ISehirService _sehirService;
        private IYolService _yolService;
        private IYolcuService _yolcuService;
        public HomeController(ISehirService sehirService, IYolService yolService, IYolcuService yolcuService)
        {
            _sehirService = sehirService;
            _yolService = yolService;
            _yolcuService = yolcuService;
        }

        public IActionResult Index()
        {
          ViewBag.sehirler= _sehirService.GetAll();
          
            return View();
        }
        public IActionResult Hakkımızda()
        {
            return View();
        }
        public IActionResult Bilet(Yol yol)
        {
            
            return View(_yolService.BiletleriGetir(yol));
        }
       
        public IActionResult Yolcu(string Nereden,string Nereye,string Tarih,int Fiyat,string Saat, int YolId)
        {
            var dolukoltuklar = _yolcuService.DoluKoltuklariGetir(Nereden,  Nereye,  Tarih,  Fiyat,  Saat,  YolId );
            var koltuklar = new List<int>();
            for (int i = 1; i < 41 ; i++)
            {
                koltuklar.Add(i);
            }
            foreach (var item in dolukoltuklar)
            {
                koltuklar.Remove(item.KoltukNo);
                
            }
            ViewBag.koltuklar = koltuklar;
            Yolcu yolcu = new Yolcu()
            {
                Nereden = Nereden,
                Nereye=Nereye,
                Tarih=Tarih,
                Fiyat=Fiyat,
                Saat=Saat,
                YolId=YolId
              

                
                
            };
            

            return View(yolcu);
        }
        [HttpPost]
        public IActionResult Rezerve(Yolcu yolcu)
        {
                _yolcuService.CreateYolcu(yolcu);
                return View(yolcu);
        }
    }
}
