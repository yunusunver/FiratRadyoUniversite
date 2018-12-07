using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Core.Entities;

namespace RadyoFiratUniversite.RadyoFirat.Entities.Concrete
{
    public class Yayin : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string YayinAdi { get; set; }
        public string BaslangicSaati { get; set; }
        public string BitisSaati { get; set; }
        public string Tanim { get; set; }
        public string Gun { get; set; }
        [ForeignKey("Programci")]
        public int ProgramciId { get; set; }
        public string ImageUrl { get; set; }

        public virtual Programci Programci { get; set; }
        

    }
}
