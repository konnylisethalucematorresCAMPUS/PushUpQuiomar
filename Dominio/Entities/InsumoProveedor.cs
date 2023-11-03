namespace Dominio.Entities;
    public class InsumoProveedor : BaseEntity
    {
        public int InsumoId { get; set; }
        public Insumo ? Insumos { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor ? Proveedores { get; set; }
        
    }
