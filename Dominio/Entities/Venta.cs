namespace Dominio.Entities;
    public class Venta : BaseEntity
    {
        public DateTime Fecha { get; set; }
        public int EmpleadoId { get; set; }
        public int ClienteId { get; set; }
        public int FormaPagoId { get; set; }


    }
