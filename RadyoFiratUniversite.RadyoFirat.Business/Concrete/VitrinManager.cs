using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Concrete
{
    public class VitrinManager:IVitrinService
    {
        private IVitrinDal _vitrinDal;

        public VitrinManager(IVitrinDal vitrinDal)
        {
            _vitrinDal = vitrinDal;
        }

        public Vitrin Get(int id)
        {
            return _vitrinDal.Get(x => x.Id == id);
        }

        public List<Vitrin> GetAll()
        {
            return _vitrinDal.GetList().OrderByDescending(x=>x.CreatedDate).ToList();
        }

        public void Add(Vitrin vitrin)
        {
            vitrin.CreatedDate=DateTime.Now;
            _vitrinDal.Add(vitrin);
        }

        public void Update(Vitrin vitrin)
        {
            _vitrinDal.Update(vitrin);
        }

        public void Delete(int vitrinId)
        {
            _vitrinDal.Delete(new Vitrin(){Id = vitrinId});
        }
    }
}
