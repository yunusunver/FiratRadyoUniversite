using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Core.Entities;

namespace RadyoFiratUniversite.RadyoFirat.Entities.Concrete
{
    public class Roles : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Unvani { get; set; }

        public virtual List<Kunye> Kunye { get; set; }

        public Roles()
        {
            Kunye = new List<Kunye>();

        }

    }
}
