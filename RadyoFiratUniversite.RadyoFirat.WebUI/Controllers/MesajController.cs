using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.WebUI.Filters;
using RadyoFiratUniversite.RadyoFirat.WebUI.Models;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Controllers
{
    [AuthFilter]
    public class MesajController : Controller
    {
        private IMesajService _mesajService;

        public MesajController(IMesajService mesajService)
        {
            _mesajService = mesajService;
        }

        public ActionResult Index()
        {
            var mesajlar = _mesajService.GetAll();
            MesajListViewModel model=new MesajListViewModel
            {
                Mesajs = mesajlar
            };
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            _mesajService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}