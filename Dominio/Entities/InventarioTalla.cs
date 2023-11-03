namespace Dominio.Entities;
    public class InventarioTalla : BaseEntity
    {
        public int InventarioId { get; set; }
        public Inventario ? Inventarios { get;}
        public int TallaId { get; set; }
        public Talla ? Tallas { get; set; }

    }