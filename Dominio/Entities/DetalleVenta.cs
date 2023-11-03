namespace Dominio.Entities;
    public class DetalleVenta : BaseEntity
    {
        public int VentaId { get; set;}
        public int ProductoId { get; set;}
        public int TallaId { get; set;}
        public int Cantidad { get; set;}
        public double ValorUnit { get; set;}

    }
