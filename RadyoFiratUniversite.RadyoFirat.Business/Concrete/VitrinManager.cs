using System;
using System.Collections.Generic;
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

        public List<Vitrin> GetAll()
        {
            return _vitrinDal.GetList();
        }

        public void Add(Vitrin vitrin)
        {
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
