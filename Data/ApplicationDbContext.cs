using Microsoft.EntityFrameworkCore;
using PlataformaPrestamos.Models;
using System.Collections.Generic;

namespace PlataformaPrestamos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("TuCadenaDeConexion");
        }
    }
}