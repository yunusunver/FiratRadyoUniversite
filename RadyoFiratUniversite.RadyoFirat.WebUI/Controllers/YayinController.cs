using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;
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
        [HttpPost]
        public ActionResult Create(Yayin yayin)
        {
            _yayinService.Add(yayin);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var bulunanYayinci = _yayinService.Get(id);
            ViewBag.Unvanlar = new SelectList(_programciService.GetAll(), "Id", "AdSoyad").ToList();
            return View(bulunanYayinci);
        }

        [HttpPost]
        public ActionResult Edit(Yayin yayin)
        {
            _yayinService.Update(yayin);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _yayinService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}