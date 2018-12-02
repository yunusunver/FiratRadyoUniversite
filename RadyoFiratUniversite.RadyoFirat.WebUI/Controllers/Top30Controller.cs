using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;
using RadyoFiratUniversite.RadyoFirat.WebUI.Models;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Controllers
{
    public class Top30Controller : Controller
    {
        private ITop30Service _top30Service;

        public Top30Controller(ITop30Service top30Service)
        {
            _top30Service = top30Service;
        }

        public ActionResult Index()
        {
            var top30 = _top30Service.GetAll();
            Top30ListViewModel model=new Top30ListViewModel
            {
                Top30 = top30
            };
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Top30 top30)
        {
            _top30Service.Add(top30);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _top30Service.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var bulunanSarki = _top30Service.Get(id);
            return View(bulunanSarki);
        }
        [HttpPost]
        public ActionResult Edit(Top30 top30)
        {
            _top30Service.Update(top30);
            return RedirectToAction("Index");
        }
    }
}