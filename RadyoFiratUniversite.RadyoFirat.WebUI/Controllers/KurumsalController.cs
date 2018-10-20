using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Controllers
{
    public class KurumsalController : Controller
    {
        private IKurumsalService _kurumsalService;

        public KurumsalController(IKurumsalService kurumsalService)
        {
            _kurumsalService = kurumsalService;
        }

        public ActionResult Index()
        {
            var kurumsal = _kurumsalService.GetAll();
            return View();
        }
    }
}