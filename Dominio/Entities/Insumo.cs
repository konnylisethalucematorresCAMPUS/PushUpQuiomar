namespace Dominio.Entities;
    public class Insumo
    {
        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public double ValorUnit { get; set; }
        public double StockMinimo { get; set; }
        public double StockMaximo { get; set; }
        public ICollection<InsumoProveedor> ? InsumosProveedores{ get; set; }
        
    }