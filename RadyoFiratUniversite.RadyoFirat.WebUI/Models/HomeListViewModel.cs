using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Models
{
    public class HomeListViewModel
    {
        public List<Iletisim> Iletisims{get; internal set; }
        public List<Programci> Programcis { get; internal set; }
        public List<Kunye> Kunyes { get; internal set; }
        public List<Kurumsal> Kurumsals { get; internal set; }
        public List<Vitrin> Vitrins { get; internal set; }
        public List<Yayin> Yayins { get; internal set; }
        public  List<Top30> Top30 { get; internal set; }
    }
}
