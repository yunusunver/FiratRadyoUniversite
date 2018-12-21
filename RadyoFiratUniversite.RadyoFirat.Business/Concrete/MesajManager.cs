using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Concrete;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Concrete
{
    public class MesajManager:IMesajService
    {
        private IMesajDal _mesajDal;

        public MesajManager(IMesajDal mesajDal)
        {
            _mesajDal = mesajDal;
        }

        public Mesaj Get(int id)
        {
            return _mesajDal.Get(x => x.Id == id);
        }

        public List<Mesaj> GetAll()
        {
            return _mesajDal.GetList().OrderByDescending(x=>x.Id).ToList();
        }

        public void Add(Mesaj mesaj)
        {
            _mesajDal.Add(mesaj);
        }

        public void Update(Mesaj mesaj)
        {
            _mesajDal.Update(mesaj);
        }

        public void Delete(int mesajId)
        {
            _mesajDal.Delete(new Mesaj(){Id = mesajId});
        }
    }
}
