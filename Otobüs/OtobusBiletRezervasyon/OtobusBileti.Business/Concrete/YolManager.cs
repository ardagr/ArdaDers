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
    public class YolManager : IYolService
    {
        private IYolRepository _yolRepository;

        public YolManager(IYolRepository yolRepository)
        {
            _yolRepository = yolRepository;
        }

        public List<Yol> BiletleriGetir(Yol yol)
        {
            return _yolRepository.BiletleriGetir(yol);

        }

        public void Create(Yol entity)
        {
            _yolRepository.Create(entity);
        }

        public void Delete(Yol entity)
        {
            _yolRepository.Delete(entity);
        }

        public List<Yol> GetAll()
        {
            return _yolRepository.GetAll();
        }

        public Yol GetById(int id)
        {
            return _yolRepository.GetById(id);
        }

        public void Update(Yol entity)
        {
            throw new NotImplementedException();
        }
    }
}
