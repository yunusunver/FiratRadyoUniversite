using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Concrete
{
    public class YayinManager:IYayinService
    {
        private IYayinDal _yayinDal;

        public YayinManager(IYayinDal yayinDal)
        {
            _yayinDal = yayinDal;
        }

        public List<Yayin> GetAll()
        {
            return _yayinDal.GetList();
        }

        public List<Yayin> GetListBySaati(string baslangicSaati)
        {
            return _yayinDal.GetList().OrderByDescending(x=>x.BaslangicSaati).ToList();
        }

        

        public void Add(Yayin yayin)
        {
            _yayinDal.Add(yayin);
        }

        public void Update(Yayin yayin)
        {
            _yayinDal.Update(yayin);
        }

        public void Delete(int yayinId)
        {
            _yayinDal.Delete(new Yayin(){Id = yayinId});
        }
    }
}
