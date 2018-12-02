using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.WebUI.Models;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProgramciService _programciService;
        private IKunyeService _kunyeService;
        private IYayinService _yayinService;
        private IVitrinService _vitrinService;
        private IIletisimService _iletisimService;
        private IKurumsalService _kurumsalService;
        private ITop30Service _top30Service;

        public HomeController(IProgramciService programciService, IKunyeService kunyeService, IYayinService yayinService, IVitrinService vitrinService, IIletisimService iletisimService, IKurumsalService kurumsalService,ITop30Service top30Service)
        {
            _programciService = programciService;
            _kunyeService = kunyeService;
            _yayinService = yayinService;
            _vitrinService = vitrinService;
            _iletisimService = iletisimService;
            _kurumsalService = kurumsalService;
            _top30Service = top30Service;
        }

        public ActionResult Index()
        {
            var programci = _programciService.GetAll();
            var kunyes = _kunyeService.GetAll();
            var yayins = _yayinService.GetAll();
            var vitrins = _vitrinService.GetAll();
            var iletisims = _iletisimService.GetAll();
            var kurumsals = _kurumsalService.GetAll();
            var top30 = _top30Service.GetAll();

            HomeListViewModel model = new HomeListViewModel
            {
                Kunyes = kunyes,
                Yayins = yayins,
                Iletisims = iletisims,
                Kurumsals = kurumsals,
                Vitrins = vitrins,
                Programcis = programci,
                Top30=top30
            };

            return View(model);
        }
    }
}