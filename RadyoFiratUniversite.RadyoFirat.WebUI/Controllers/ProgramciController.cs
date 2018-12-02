using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
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
        private IYayinService _yayinService;
        private IHostingEnvironment _env;

        public ProgramciController(IProgramciService programciService, IYayinService yayinService, IHostingEnvironment env)
        {
            _programciService = programciService;
            _yayinService = yayinService;
            _env = env;
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
            
            //var path = Path.Combine(_env.ContentRootPath, "\\wwwroot", bulunanProgramci.ImageUrl);
            
            //var filePath = Path.Combine("wwwroot", bulunanProgramci.ImageUrl);
            if (System.IO.File.Exists(_env.WebRootPath+bulunanProgramci.ImageUrl))
            {
                System.IO.File.Delete(_env.WebRootPath + bulunanProgramci.ImageUrl);
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
        public async Task<IActionResult> Edit(Programci programci,IFormFile image)
        {
            if (image != null)
            {
                if (System.IO.File.Exists(_env.WebRootPath + programci.ImageUrl))
                {
                    System.IO.File.Delete(_env.WebRootPath + programci.ImageUrl);
                }
                if (image == null || image.Length == 0)
                {
                    return Content("not image selected");
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/Programcilar", image.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await image.CopyToAsync(stream);

                }

                programci.ImageUrl = "/image/Programcilar/" + image.FileName;
            }

           



            _programciService.Update(programci);
            return RedirectToAction("Index");
        }
    }
}