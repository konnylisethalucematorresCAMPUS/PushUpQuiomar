namespace Dominio.Entities;
    public class DetalleOrden : BaseEntity
    {
        public int OrdenId { get; set; }
        public Orden ? Ordenes { get; set; }
        public int PrendaId { get; set; }
        public Prenda ? Prendas { get; set; }
        public int CantidadProducir { get; set; }
        public int ColorId { get; set; }
        public Color ? Colores { get; set; }
        public int CantidadProducida { get; set; }
        public int EstadoId { get; set; }
        public Estado ? Estados { get; set; }

    }
