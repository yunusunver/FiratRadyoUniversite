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
        Yayin Get(int id);
        void Add(Yayin yayin);
        void Update(Yayin yayin);
        void Delete(int yayinId);

    }
}
