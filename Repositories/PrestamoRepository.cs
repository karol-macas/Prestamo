using PlataformaPrestamo.Data;
using PlataformaPrestamos.Models;
using System.Collections.Generic;

namespace PlataformaPrestamos.Repositories
{
    public class PrestamoRepository
    {
        private readonly ApplicationDbContext _context;

        public PrestamoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Prestamo> GetByUsuarioId(int usuarioId)
        {
            return _context.Prestamos.Where(p => p.UsuarioId == usuarioId).ToList();
        }

        public void Add(Prestamo prestamo)
        {
            _context.Prestamos.Add(prestamo);
            _context.SaveChanges();
        }
    }
}