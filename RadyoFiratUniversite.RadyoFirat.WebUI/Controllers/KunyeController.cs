using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;
using RadyoFiratUniversite.RadyoFirat.WebUI.Models;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Controllers
{
    public class KunyeController : Controller
    {
        private IKunyeService _kunyeService;
        private IRolesService _rolesService;
        

        public KunyeController(IKunyeService kunyeService,IRolesService rolesService)
        {
            _rolesService = rolesService;
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
            ViewBag.Unvanlar = new SelectList(_rolesService.GetAll(), "Id", "Unvani").ToList();
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
            ViewBag.Unvanlar = new SelectList(_rolesService.GetAll(), "Id", "Unvani").ToList();
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