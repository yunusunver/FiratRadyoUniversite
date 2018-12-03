using System;
using System.Collections.Generic;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Abstract
{
    public interface IAdminService
    {
        Admin Get(string kullaniciAdi);
        List<Admin> GetAll();
        void Add(Admin admin);
        void Update(Admin admin);
        void Delete(string kullaniciAdi);
    }
}
