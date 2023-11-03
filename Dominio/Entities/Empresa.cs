namespace Dominio.Entities;

    public class Empresa : BaseEntity
    {
        public string ? Nit { get; set; }
        public string ? RazonSocial { get; set; }
        public string ? RepresentanteLegal { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int MunicipioId { get; set; }
        public Municipio ? Municipios { get; set; }


    }