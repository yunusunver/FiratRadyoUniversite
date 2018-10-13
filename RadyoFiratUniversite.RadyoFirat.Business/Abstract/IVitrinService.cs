using System;
using System.Collections.Generic;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Abstract
{
    public interface IVitrinService
    {
        List<Vitrin> GetAll();
        void Add(Vitrin vitrin);
        void Update(Vitrin vitrin);
        void Delete(int vitrinId);
    }
}
