namespace Dominio.Entities;
    public class InsumoPrenda : BaseEntity
    {
        public int InsumoId { get; set; }
        public Insumo ? Insumo { get; set; }
        public int PrendaId { get; set; }
        public Prenda ? Prenda { get; set; }
        public int Cantidad { get; set; }
    
    }
