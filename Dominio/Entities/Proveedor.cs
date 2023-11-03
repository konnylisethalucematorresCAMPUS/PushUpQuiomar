namespace Dominio.Entities;
    public class Proveedor : BaseEntity
    {
        public string ? NitProveedor { get; set; }
        public string ? Nombre { get; set; }
        public int TipoPersonaId { get; set; }
        public TipoPersona ? TiposPersonas { get; set; }

        public int MunicipioId { get; set; }
        public Municipio? Municipios { get; set; }

        public ICollection<InsumoProveedor> ? InsumosProveedores { get; set;}
    }
