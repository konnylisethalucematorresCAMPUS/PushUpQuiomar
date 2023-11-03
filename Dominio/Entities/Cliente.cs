namespace Dominio.Entities;
    public class Cliente : BaseEntity
    {
        public string ? Nombre { get; set; }
        public int TipoPersonaId { get; set; }
        public TipoPersona ? TiposPersonas { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int MunicipioId { get; set; }
        public Municipio? Municipios { get; set; }
        public ICollection<Venta> ? Ventas { get; set; }
        public ICollection<Orden> ? Ordenes { get; set; }

    }
