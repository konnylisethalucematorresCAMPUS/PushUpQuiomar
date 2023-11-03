namespace Dominio.Entities;
    public class InventarioPrenda : BaseEntity
    {
        public int InventarioId { get; set; }
        public string ? CodInv { get; set; }
        public int PrendaId { get; set; }
        public double VtaCop { get; set; }
        public double VtaUsd { get; set; }
    }
