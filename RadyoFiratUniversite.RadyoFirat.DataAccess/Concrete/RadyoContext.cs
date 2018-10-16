using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;


namespace RadyoFiratUniversite.RadyoFirat.DataAccess.Concrete
{
    public class RadyoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-D0LF9Q3\SQLEXPRESS;Database=RadyoFirat;Trusted_Connection=true");
            
        }

        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Kunye> Kunye { get; set; }
        public DbSet<Kurumsal> Kurumsal { get; set; }
        public DbSet<Programci> Programci{ get; set; }
        public DbSet<Roles> Roles{ get; set; }
        public DbSet<Vitrin> Vitrin { get; set; }
        public DbSet<Yayin> Yayin { get; set; }
    }
}
