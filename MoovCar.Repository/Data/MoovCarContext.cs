using System;
using System.Collections.Generic;
using System.Text;
using MoovCar.Domain;
using Microsoft.EntityFrameworkCore;

namespace MoovCar.Data
{
    public class MoovCarContext : DbContext
    {
        public MoovCarContext(DbContextOptions<MoovCarContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
        }
    }
}
