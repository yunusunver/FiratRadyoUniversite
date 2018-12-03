using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;
using RadyoFiratUniversite.RadyoFirat.WebUI.Filters;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [AuthFilter]
        public ActionResult Edit()
        {
            var kullaniciAdi = HttpContext.Session.GetString("kullaniciAdi");
            var kullanici = _adminService.Get(kullaniciAdi);
            return View(kullanici);
        }
        [AuthFilter]
        [HttpPost]
        public ActionResult Edit(Admin admin)
        {
            _adminService.Update(admin);
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var kullanici = _adminService.Get(admin.KullaniciAdi);

            if (kullanici==null)
            {
                return RedirectToAction("Index","Home");
            }

            try
            {
                if (kullanici.KullaniciAdi==admin.KullaniciAdi && kullanici.Sifre==admin.Sifre)
                {
                    HttpContext.Session.SetString("kullaniciAdi",kullanici.KullaniciAdi);
                    HttpContext.Session.SetString("sifre",kullanici.Sifre);
                    return RedirectToAction("Index", "Yayin");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home");
            }

        }
        
        public ActionResult Logout()
        {
            HttpContext.Session.Remove("kullaniciAdi");
            HttpContext.Session.Remove("sifre");
            return RedirectToAction("Index", "Home");
        }
    }
}