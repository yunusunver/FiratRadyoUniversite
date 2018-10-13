using System;
using System.Collections.Generic;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Abstract
{
    public interface IYayinService
    {
        List<Yayin> GetAll();
        List<Yayin> GetListBySaati(string baslangicSaati);
        
        void Add(Yayin yayin);
        void Update(Yayin yayin);
        void Delete(int yayinId);

    }
}
