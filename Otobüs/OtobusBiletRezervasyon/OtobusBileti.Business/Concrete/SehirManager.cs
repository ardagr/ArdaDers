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
    public class SehirManager : ISehirService
    {
        private ISehirRepository _sehirRepository;
        public SehirManager(ISehirRepository sehirRepository)
        {
            _sehirRepository = sehirRepository;
        }

        public void Create(Sehir entity)
        {
            _sehirRepository.Create(entity);
        }

        public void Delete(Sehir entity)
        {
            _sehirRepository.Delete(entity);
        }

        public List<Sehir> GetAll()
        {
           return _sehirRepository.GetAll();
        }

        public Sehir GetById(int id)
        {
            return _sehirRepository.GetById(id);
        }

        public void Update(Sehir entity)
        {
            throw new NotImplementedException();
        }
    }
}
