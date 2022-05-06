using DersProje.Models.Concrete;
using DersProje.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersProje.Controllers
{
    public class OgrenciController : Controller
    {
       

        public IActionResult Index()
        {
            var _context = new DersProjeDbContext();
            var ogrenciler = _context.Ogrenciler.ToList();
            return View(ogrenciler);
           
        }
        public Ogrenci GetirIdKurs(int id)
        {
            using(var context =new DersProjeDbContext())
            {
                return context.Ogrenciler
                    .Where(x => x.OgrenciId == id)
                    .Include(x => x.OgrenciDers)
                    .ThenInclude(x => x.Dersler)
                    .FirstOrDefault();
            }
        }
        public IActionResult Detay(int id)
        {
            var context = new DersProjeDbContext();
            var entity = GetirIdKurs(id);
            var model = new StudentModel()
            {
                StudentId = entity.OgrenciId,
                No = entity.OgrenciNo,
                FirstName = entity.OgrenciIsmi,
                LastName = entity.OgrenciSoyad,
                DateOfBirth = entity.DogumTarihi,
                DateOfRegistration = entity.KayitTarihi,
                Period = entity.Donemi,
                DepartmentId = entity.OgrenciBolumId,
                SelectedCourses = entity.OgrenciDers.Select(x => x.Dersler).ToList()
            };
            ViewBag.Courses = context.Dersler.ToList();
            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(int id, StudentModel ogrenci)
        {
            
            var context = new DersProjeDbContext();
            var gelenId = context.Ogrenciler.Find(id);
           
            return View();
        }

    }
}
