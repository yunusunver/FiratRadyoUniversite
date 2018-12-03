using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Concrete
{
    public class AdminManager:IAdminService
    {
        private IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin Get(string kullaniciAdi)
        {
            return _adminDal.Get(x=>x.KullaniciAdi==kullaniciAdi);
        }

        public List<Admin> GetAll()
        {
            return _adminDal.GetList();
        }


        public void Add(Admin admin)
        {
            _adminDal.Add(admin);
        }

        public void Update(Admin admin)
        {
            _adminDal.Update(admin);
        }

        public void Delete(string kullaniciAdi)
        {
            _adminDal.Delete(new Admin(){KullaniciAdi = kullaniciAdi});
        }
    }
}
