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
    public class VitrinController : Controller
    {
        private IVitrinService _vitrinService;
        private IHostingEnvironment _env;

        public VitrinController(IVitrinService vitrinService,IHostingEnvironment env)
        {
            _vitrinService = vitrinService;
            _env = env;
        }

        public ActionResult Index()
        {
            var vitrinler = _vitrinService.GetAll();
            VitrinListViewModel model=new VitrinListViewModel
            {
                Vitrinler = vitrinler
            };
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(IFormFile image,Vitrin vitrin)
        {

            if (image == null || image.Length == 0)
            {
                return Content("not image selected");
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/VitrinResimleri", image.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await image.CopyToAsync(stream);

            }

            vitrin.ImageUrl = "/image/VitrinResimleri/" + image.FileName;
            _vitrinService.Add(vitrin);

            return RedirectToAction("Index");
           
        }

        public ActionResult Delete(int id)
        {
            var bulunanResim = _vitrinService.Get(id);
           
            if (System.IO.File.Exists(_env.WebRootPath + bulunanResim.ImageUrl))
            {
                System.IO.File.Delete(_env.WebRootPath + bulunanResim.ImageUrl);
            }

            _vitrinService.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var bulunanResim = _vitrinService.Get(id);

            return View(bulunanResim);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Vitrin vitrin, IFormFile image)
        {
            if (image != null)
            {
                if (System.IO.File.Exists(_env.WebRootPath + vitrin.ImageUrl))
                {
                    System.IO.File.Delete(_env.WebRootPath + vitrin.ImageUrl);
                }
                if (image == null || image.Length == 0)
                {
                    return Content("not image selected");
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/VitrinResimleri", image.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await image.CopyToAsync(stream);

                }

                vitrin.ImageUrl = "/image/VitrinResimleri/" + image.FileName;
            }





            _vitrinService.Update(vitrin);
            return RedirectToAction("Index");
        }
    }
}