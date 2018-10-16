using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Concrete
{
    public class IletisimManager:IIletisimService
    {
        private IIletisimDal _iletisimDal;

        public IletisimManager(IIletisimDal iletisimDal)
        {
            _iletisimDal = iletisimDal;
        }

        public Iletisim Get(int id)
        {
            return _iletisimDal.Get(x => x.Id == id);
        }
        public List<Iletisim> GetAll()
        {
            return _iletisimDal.GetList();
        }

        public void Add(Iletisim iletisim)
        {
            _iletisimDal.Add(iletisim);
        }

        public void Update(Iletisim iletisim)
        {
            _iletisimDal.Update(iletisim);
        }

        public void Delete(int iletisimId)
        {
            _iletisimDal.Delete(new Iletisim(){Id = iletisimId});
        }
    }
}
