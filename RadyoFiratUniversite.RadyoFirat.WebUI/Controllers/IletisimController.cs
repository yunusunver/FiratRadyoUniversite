using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;
using RadyoFiratUniversite.RadyoFirat.WebUI.Filters;
using RadyoFiratUniversite.RadyoFirat.WebUI.Models;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Controllers
{
    [AuthFilter]
    public class IletisimController : Controller
    {
        private IIletisimService _iletisimService;

        public IletisimController(IIletisimService iletisimService)
        {
            _iletisimService = iletisimService;
        }
        
        public ActionResult Index()
        {
            var iletisim = _iletisimService.GetAll();

            IletisimListViewModel model=new IletisimListViewModel
            {
                Iletisims=iletisim
            };

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            _iletisimService.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Iletisim iletisim)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _iletisimService.Add(iletisim);


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
            var bulunanIletisim = _iletisimService.Get(id);
            return View(bulunanIletisim);
        }

        [HttpPost]
        public ActionResult Edit(Iletisim iletisim)
        {
            _iletisimService.Update(iletisim);
            return RedirectToAction("Index");
        }
    }
}