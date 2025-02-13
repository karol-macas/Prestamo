namespace PlataformaPrestamos.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public decimal Monto { get; set; }
        public int Plazo { get; set; } // En meses
        public decimal TasaInteres { get; set; } // Tasa de interés anual
        public string Estado { get; set; } // "Activo", "Cancelado"
    }
}