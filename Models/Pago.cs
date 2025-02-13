namespace PlataformaPrestamos.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public int PrestamoId { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
    }
}