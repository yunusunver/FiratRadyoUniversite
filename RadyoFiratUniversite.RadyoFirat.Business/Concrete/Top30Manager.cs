using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Concrete
{
    public class Top30Manager:ITop30Service
    {
        private ITop30Dal _top30Dal;

        public Top30Manager(ITop30Dal top30Dal)
        {
            _top30Dal = top30Dal;
        }

        public Top30 Get(int id)
        {
            return _top30Dal.Get(x => x.Id == id);
        }

        public List<Top30> GetAll()
        {
            return _top30Dal.GetList().OrderBy(x=>x.TopSirasi).ToList();
        }

        public void Add(Top30 top30)
        {
            _top30Dal.Add(top30);
        }

        public void Update(Top30 top30)
        {
            _top30Dal.Update(top30);
        }

        public void Delete(int top30Id)
        {
            _top30Dal.Delete(new Top30(){Id = top30Id});
        }
    }
}
