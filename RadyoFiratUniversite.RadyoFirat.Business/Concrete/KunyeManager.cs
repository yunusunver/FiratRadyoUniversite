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

        public List<Kunye> GetAll()
        {
            return _kunyeDal.GetList().OrderByDescending(x=>x.Id).ToList();
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
