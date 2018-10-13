﻿using System;
using System.Collections.Generic;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Concrete
{
    public class KurumsalManager:IKurumsalService
    {
        private IKurumsalDal _kurumsalDal;

        public KurumsalManager(IKurumsalDal kurumsalDal)
        {
            _kurumsalDal = kurumsalDal;
        }

       

        public List<Kurumsal> GetAll()
        {
            return _kurumsalDal.GetList();
        }

        public void Add(Kurumsal kurumsal)
        {
            _kurumsalDal.Add(kurumsal);
        }

        public void Update(Kurumsal kurumsal)
        {
            _kurumsalDal.Update(kurumsal);
        }

        public void Delete(int kurumsalId)
        {
            _kurumsalDal.Delete(new Kurumsal(){Id = kurumsalId});
        }
    }
}
