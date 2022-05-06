using DersProje.Models.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersProje.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly DersProjeDbContext _context;
        public OgrenciController(DersProjeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
                var ogrenciler = _context.Ogrenciler.ToList();
                return View(ogrenciler);
            
           //var ogrenciler= _context.Ogrenciler.ToList();
            //return View();
        }
    }
}
