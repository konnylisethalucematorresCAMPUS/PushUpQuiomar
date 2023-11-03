namespace Dominio.Entities;
    public class Inventario : BaseEntity
    {
     public string ? CodigoInv { get; set; }
     public int PrendaId { get; set; }
     public Prenda ? Prendas { get; set; }
     public double ValorVtaCop { get; set; }
     public double ValorVtaUsd { get; set; }
     public ICollection<InventarioTalla> ? InventariosTallas { get; set; }

    }