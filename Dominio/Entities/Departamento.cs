namespace Dominio.Entities;
    public class Departamento : BaseEntity
    {
        public string ? Nombre { get; set; }
        public int PaisId { get; set; }
        public Pais ? Pais { get; set; }
        public ICollection<Municipio> ? Municipios { get; set; }
    }
