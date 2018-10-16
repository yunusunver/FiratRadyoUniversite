using System;
using System.Collections.Generic;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Core.DataAccess;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract
{
    public interface IKunyeDal:IEntityRepository<Kunye>
    {
        List<Kunye> GetAllKunye();
    }
}
