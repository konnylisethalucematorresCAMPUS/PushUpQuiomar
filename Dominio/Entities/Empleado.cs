namespace Dominio.Entities;
    public class Empleado : BaseEntity
    {
        public string ? Nombre { get; set; }
        public int CargoId { get; set; }
        public Cargo ? Cargos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int MunicipioId { get; set; }
        public Municipio ? Municipios { get; set; }
        public ICollection<Orden> ? Ordenes { get; set; }

        
    }
