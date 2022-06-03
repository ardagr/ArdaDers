using OtobusBileti.Business.Abstract;
using OtobusBileti.Data.Abstract;
using OtobusBileti.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti.Business.Concrete
{
    public class YolcuManager : IYolcuService
    {
        private IYolcuRepository _yolcuRepository;
        public YolcuManager(IYolcuRepository yolcuRepository)
        {
            _yolcuRepository = yolcuRepository;
        }
        public void Create(Yolcu entity)
        {
            _yolcuRepository.Create(entity);
        }

        public void CreateYolcu(Yolcu yolcu)
        {
            _yolcuRepository.CreateYolcu(yolcu);
        }

        public void Delete(Yolcu entity)
        {
            _yolcuRepository.Delete(entity);
        }

        public List<Yolcu> DoluKoltuklariGetir(string Nereden, string Nereye, string Tarih, int Fiyat, string Saat, int YolId)
        {
           return _yolcuRepository.DoluKoltuklariGetir(Nereden, Nereye, Tarih, Fiyat, Saat, YolId);
        }

        public List<Yolcu> GetAll()
        {
            return _yolcuRepository.GetAll();
        }

        public Yolcu GetById(int id)
        {
           return _yolcuRepository.GetById(id);
        }

        public void Update(Yolcu entity)
        {
            throw new NotImplementedException();
        }
    }
}
