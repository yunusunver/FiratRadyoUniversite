using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Concrete
{
    public class KunyeManager:IKunyeService
    {
        private IKunyeDal _kunyeDal;

        public KunyeManager(IKunyeDal kunyeDal)
        {
            _kunyeDal = kunyeDal;
        }

        public Kunye Get(int id)
        {
            return _kunyeDal.Get(x=>x.Id==id);
        }


        public List<Kunye> GetAll()
        {
            return _kunyeDal.GetAllKunye().OrderBy(x=>x.RoleId).ToList();
        }

        public void Add(Kunye kunye)
        {
           
            _kunyeDal.Add(kunye);
        }

        public void Update(Kunye kunye)
        {
           
            _kunyeDal.Update(kunye);
        }

        public void Delete(int kunyeId)
        {
            _kunyeDal.Delete(new Kunye(){Id = kunyeId});
        }
    }
}
