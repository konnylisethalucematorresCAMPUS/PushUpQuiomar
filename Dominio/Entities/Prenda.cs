namespace Dominio.Entities;
    public class Prenda : BaseEntity
    {
        public string ? Nombre { get; set; }
        public double ValorUnitCop { get; set; }
        public double ValorUnitUsd { get; set; }
        public int EstadoId { get; set; }
        public int TipoProteccionId { get; set; }
        public int GeneroId { get; set; }
        public string ? Codigo { get; set; }
    }