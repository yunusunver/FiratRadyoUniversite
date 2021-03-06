﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RadyoFiratUniversite.RadyoFirat.Core.DataAccess.EntityFramework;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.DataAccess.Concrete
{
    public class EfYayinDal:EfEntityRepositoryBase<Yayin,RadyoContext>,IYayinDal
    {
        public List<Yayin> GetListProgramci()
        {
            using (var context=new RadyoContext())
            {
                return context.Yayin.Include("Programci").ToList();
            }
        }
    }
}
