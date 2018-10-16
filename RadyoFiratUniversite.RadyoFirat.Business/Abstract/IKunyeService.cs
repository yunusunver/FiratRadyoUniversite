using System;
using System.Collections.Generic;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Abstract
{
    public interface IKunyeService
    {
        Kunye Get(int id);
        List<Kunye> GetAll();
        void Add(Kunye kunye);
        void Update(Kunye kunye);
        void Delete(int kunyeId);
    }
}
