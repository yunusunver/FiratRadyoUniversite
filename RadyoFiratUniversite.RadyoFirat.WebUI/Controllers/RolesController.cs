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
    public class RolesController : Controller
    {
        private IRolesService _rolesService;
      

        public RolesController(IRolesService rolesService)
        {
            _rolesService = rolesService;
           
        }

        public ActionResult Index()
        {
            var roller = _rolesService.GetAll();

            RolesListViewModel model=new RolesListViewModel
            {
                Roller = roller
            };

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Roles roles)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _rolesService.Add(roles);
                   

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
            
            _rolesService.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var unvan = _rolesService.Get(id);
            return View(unvan);
        }

        [HttpPost]
        public ActionResult Edit(Roles roles)
        {
            _rolesService.Update(roles);
            return RedirectToAction("Index");
        }
    }
}