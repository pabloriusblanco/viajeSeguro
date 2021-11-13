using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ViajeSeguro.Models
{
    public class ViajeSeguroDBContext : DbContext
    {
        public virtual DbSet<Icon> Icons { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<Pasajero> Pasajeros { get; set; }
        public virtual DbSet<Cotizacion> Cotizacions { get; set; }
        public virtual DbSet<EstadoPago> EstadoPagos { get; set; }
        public ViajeSeguroDBContext(DbContextOptions options) : base(options)
        {

        }

        protected ViajeSeguroDBContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

       // partial void OnModelCreatingParcial(ModelBuilder modelBuilder);
    }
}
