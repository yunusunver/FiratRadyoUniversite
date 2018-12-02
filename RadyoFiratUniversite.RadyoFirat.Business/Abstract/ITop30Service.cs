using System;
using System.Collections.Generic;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Abstract
{
    public interface ITop30Service
    {
        Top30 Get(int id);
        List<Top30> GetAll();
        void Add(Top30 top30);
        void Update(Top30 top30);
        void Delete(int top30Id);
    }
}
