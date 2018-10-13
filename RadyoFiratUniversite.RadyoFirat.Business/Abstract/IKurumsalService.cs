using System;
using System.Collections.Generic;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Abstract
{
    public interface IKurumsalService
    {
        
        List<Kurumsal> GetAll();
        void Add(Kurumsal kurumsal);
        void Update(Kurumsal kurumsal);
        void Delete(int kurumsalId);
    }
}
