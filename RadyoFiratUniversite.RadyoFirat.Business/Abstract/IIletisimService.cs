using System;
using System.Collections.Generic;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Abstract
{
    public interface IIletisimService
    {
        Iletisim Get(int id);
        List<Iletisim> GetAll();
        void Add(Iletisim iletisim);
        void Update(Iletisim iletisim);
        void Delete(int iletisimId);
    }
}
