using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Core.Entities;

namespace RadyoFiratUniversite.RadyoFirat.Entities.Concrete
{
    public class Top30:IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int TopSirasi { get; set; }
        public string SanatciAdi { get; set; }
        public string SarkiAdi { get; set; }
    }
}
