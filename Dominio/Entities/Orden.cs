namespace Dominio.Entities;
    public class Orden : BaseEntity
    {
        public DateTime Fecha { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado ? Empleados { get; set; }
        public int ClienteId { get; set; }
        public Cliente ? Clientes { get; set; }
        public int EstadoId { get; set; }
        public Estado ? Estados { get; set; }
        public ICollection<DetalleOrden> ? DetallesOrdenes { get; set; }
    }
