using System;
using System.Collections.Generic;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Abstract
{
    public interface IMesajService
    {
        Mesaj Get(int id);
        List<Mesaj> GetAll();
        void Add(Mesaj mesaj);
        void Update(Mesaj mesaj);
        void Delete(int mesajId);
    }
}
