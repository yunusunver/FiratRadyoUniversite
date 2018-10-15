using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.WebUI.Models;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Controllers
{
    public class YayinController : Controller
    {
        private IYayinService _yayinService;

        public YayinController(IYayinService yayinService)
        {
            _yayinService = yayinService;
        }

        public ActionResult Index()
        {
            var yayinlar = _yayinService.GetAll();
            YayinListViewModel model=new YayinListViewModel
            {
                Yayinlar = yayinlar
            };
            return View(model);
        }

        public ActionResult Create( )
        {
            return View();
        }
    }
}