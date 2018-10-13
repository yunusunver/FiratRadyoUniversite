using System;
using System.Collections.Generic;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Abstract
{
    public interface IProgramciService
    {
        List<Programci> GetAll();
        List<Programci> GetListByCreatedDate(DateTime createdDate);
        void Add(Programci programci);
        void Update(Programci programci);
        void Delete(int programciId);
    }
}
