using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly IProgramciService _programciService;

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
        //[HttpPost]
        //public ActionResult Create(Programci programci)
        //{
        //    _programciService.Add(programci);
        //    return RedirectToAction("Index");
        //}
        [HttpPost]
        public async Task<IActionResult> Create(IFormFile image,Programci programci)
        {
            if (image==null || image.Length==0)
            {
                return Content("not image selected");
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/Programcilar", image.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await image.CopyToAsync(stream);
               
            }

            programci.ImageUrl = "/image/Programcilar/"+ image.FileName;
            _programciService.Add(programci);

            return RedirectToAction("Index");
        }

        

        
        public ActionResult Delete(int id)
        {
            var bulunanProgramci = _programciService.Get(id);
            if (System.IO.File.Exists())
            {
                System.IO.File.Delete();
            }
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