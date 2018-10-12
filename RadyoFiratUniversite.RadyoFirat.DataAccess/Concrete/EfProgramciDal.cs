using System;
using System.Collections.Generic;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Core.DataAccess;
using RadyoFiratUniversite.RadyoFirat.Core.DataAccess.EntityFramework;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.DataAccess.Concrete
{
    public class EfProgramciDal:EfEntityRepositoryBase<Programci,RadyoContext>,IProgramciDal
    {
    }
}
