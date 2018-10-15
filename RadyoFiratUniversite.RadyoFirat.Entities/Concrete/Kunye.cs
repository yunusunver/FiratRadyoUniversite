using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Core.Entities;

namespace RadyoFiratUniversite.RadyoFirat.Entities.Concrete
{
    public class Kunye : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Isim { get; set; }
        [ForeignKey("Roles")]
        public int RoleId { get; set; }
        public virtual Roles Roles { get; set; }


    }
}
