using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.WebUI.Models;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Controllers
{
    public class YayinakisiController : Controller
    {
        private IYayinService _yayinService;
        private IIletisimService _iletisimService;

        public YayinakisiController(IYayinService yayinService,IIletisimService iletisimService)
        {
            _yayinService = yayinService;
            _iletisimService = iletisimService;
        }

        public ActionResult Index()
        {
            var yayinlar = _yayinService.GetAll();
            var iletisim = _iletisimService.GetAll();
            YayinListViewModel model=new YayinListViewModel()
            {
                Yayinlar = yayinlar,
                Iletisim=iletisim
            };
            return View(model);
        }
    }
}