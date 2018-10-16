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
    public class KunyeController : Controller
    {
        private IKunyeService _kunyeService;
        

        public KunyeController(IKunyeService kunyeService) 
        {
            
            _kunyeService=kunyeService;
        }

        

        public ActionResult Index()
        {
           
            KunyeListViewModel model=new KunyeListViewModel
            {
                Kunyes=_kunyeService.GetAll()
                
            };
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Kunye kunye)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _kunyeService.Add(kunye);


                }
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Create");
            }
        }

        public ActionResult Delete(int id)
        {
            _kunyeService.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var bulunanKunye = _kunyeService.Get(id);
            return View(bulunanKunye);
        }

        [HttpPost]
        public ActionResult Edit(Kunye kunye)
        {
            _kunyeService.Update(kunye);
            return RedirectToAction("Index");
        }
    }
}