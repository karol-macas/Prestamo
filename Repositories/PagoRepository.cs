using PlataformaPrestamo.Data;
using PlataformaPrestamos.Models;
using System.Collections.Generic;

namespace PlataformaPrestamos.Repositories
{
    public class PagoRepository
    {
        private readonly ApplicationDbContext _context;

        public PagoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Pago> GetByPrestamoId(int prestamoId)
        {
            return _context.Pagos.Where(p => p.PrestamoId == prestamoId).ToList();
        }

        public void Add(Pago pago)
        {
            _context.Pagos.Add(pago);
            _context.SaveChanges();
        }
    }
}