using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.WebUI.Filters;
using RadyoFiratUniversite.RadyoFirat.WebUI.Models;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Controllers
{
    [AuthFilter]
    public class YayinController : Controller
    {
        private IYayinService _yayinService;
        private IProgramciService _programciService;

        public YayinController(IYayinService yayinService,IProgramciService programciService)
        {
            _yayinService = yayinService;
            _programciService = programciService;
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

        public ActionResult Create()
        {
            ViewBag.Unvanlar = new SelectList(_programciService.GetAll(), "Id", "AdSoyad").ToList();
            return View();
        }
    }
}