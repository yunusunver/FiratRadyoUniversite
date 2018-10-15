using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;
using RadyoFiratUniversite.RadyoFirat.WebUI.Models;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Controllers
{
    public class ProgramciController : Controller
    {
        private IProgramciService _programciService;

        public ProgramciController(IProgramciService programciService)
        {
            _programciService = programciService;
        }

        public ActionResult Index()
        {
 
            var programcilar = _programciService.GetAll();

            ProgramciListViewModel model=new ProgramciListViewModel
            {
                Programcilar=programcilar
            };

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Programci programci)
        {
            _programciService.Add(programci);
            return RedirectToAction("Index");
        }

        

        
        public ActionResult Delete(int id)
        {
            _programciService.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var bulunanProgramci=_programciService.Get(id);
            
            return View(bulunanProgramci);
        }

        [HttpPost]
        public ActionResult Edit(Programci programci)
        {
            

            _programciService.Update(programci);
            return RedirectToAction("Index");
        }
    }
}