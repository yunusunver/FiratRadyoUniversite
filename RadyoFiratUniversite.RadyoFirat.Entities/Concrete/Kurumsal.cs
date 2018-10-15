using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Core.Entities;

namespace RadyoFiratUniversite.RadyoFirat.Entities.Concrete
{
    public class Kurumsal : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Tanim { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
