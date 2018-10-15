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
    }
}