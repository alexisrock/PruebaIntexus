using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class PruebaContext : DbContext
    {
        public PruebaContext(DbContextOptions<PruebaContext> options) : base(options) { }
        public virtual DbSet<Tarea>? Tarea { get; set; }



 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarea>().ToTable("TblTarea");
            modelBuilder.Entity<Tarea>(x =>
            {
                x.HasKey(e => e.IdTarea);

            });

            base.OnModelCreating(modelBuilder);
        }



    }
}
