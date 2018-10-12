using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Core.Entities;

namespace RadyoFiratUniversite.RadyoFirat.Entities.Concrete
{
    public class Programci : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Yayin> Yayins  { get; set; }

        public Programci()
        {
                Yayins = new List<Yayin>();
        }

    }
}
