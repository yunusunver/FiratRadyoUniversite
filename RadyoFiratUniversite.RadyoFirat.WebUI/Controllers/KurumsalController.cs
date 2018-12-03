using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;
using RadyoFiratUniversite.RadyoFirat.WebUI.Filters;
using RadyoFiratUniversite.RadyoFirat.WebUI.Models;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Controllers
{
    [AuthFilter]
    public class KurumsalController : Controller
    {
        private IKurumsalService _kurumsalService;

        public KurumsalController(IKurumsalService kurumsalService)
        {
            _kurumsalService = kurumsalService;
        }

        public ActionResult Index()
        {
            var kurumsal = _kurumsalService.GetAll();
            KurumsalListViewModel model=new KurumsalListViewModel
            {
                Kurumsals=kurumsal
            };
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Kurumsal kurumsal)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _kurumsalService.Add(kurumsal);


                }
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Create");
            }
            
        }

        public ActionResult Edit(int id)
        {
            var kurumsal = _kurumsalService.Get(id);
            return View(kurumsal);
        }
        [HttpPost]
        public ActionResult Edit(Kurumsal kurumsal)
        {
            _kurumsalService.Update(kurumsal);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _kurumsalService.Delete(id);
            return RedirectToAction("Index");
        }



    }
}