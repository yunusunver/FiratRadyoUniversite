using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;
using RadyoFiratUniversite.RadyoFirat.WebUI.Filters;
using RadyoFiratUniversite.RadyoFirat.WebUI.Models;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Controllers
{
    [AuthFilter]
    public class YayinController : Controller
    {
        private IYayinService _yayinService;
        private IProgramciService _programciService;
        private IHostingEnvironment _env;

        public YayinController(IYayinService yayinService,IProgramciService programciService,IHostingEnvironment env)
        {
            _yayinService = yayinService;
            _programciService = programciService;
            _env = env;
        }

        public ActionResult Index()
        {
            var yayinlar = _yayinService.GetAll();
            YayinListViewModel model=new YayinListViewModel
            {
                Yayinlar = yayinlar
            };
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.Unvanlar = new SelectList(_programciService.GetAll(), "Id", "AdSoyad").ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(IFormFile image, Yayin yayin)
        {

            if (image == null || image.Length == 0)
            {
                return Content("not image selected");
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/Yayincilar", image.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await image.CopyToAsync(stream);

            }

            yayin.ImageUrl = "/image/Yayincilar/" + image.FileName;
            _yayinService.Add(yayin);

            return RedirectToAction("Index");

        }

        public ActionResult Edit(int id)
        {
            var bulunanYayinci = _yayinService.Get(id);
            ViewBag.Unvanlar = new SelectList(_programciService.GetAll(), "Id", "AdSoyad").ToList();
            return View(bulunanYayinci);
        }

        


        [HttpPost]
        public async Task<IActionResult> Edit(Yayin yayin, IFormFile image)
        {
            if (image != null)
            {
                if (System.IO.File.Exists(_env.WebRootPath + yayin.ImageUrl))
                {
                    System.IO.File.Delete(_env.WebRootPath + yayin.ImageUrl);
                }
                if (image == null || image.Length == 0)
                {
                    return Content("not image selected");
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/Yayincilar", image.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await image.CopyToAsync(stream);

                }

                yayin.ImageUrl = "/image/Yayincilar/" + image.FileName;
            }
            
            _yayinService.Update(yayin);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var bulunanResim = _yayinService.Get(id);

            if (System.IO.File.Exists(_env.WebRootPath + bulunanResim.ImageUrl))
            {
                System.IO.File.Delete(_env.WebRootPath + bulunanResim.ImageUrl);
            }


            _yayinService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}