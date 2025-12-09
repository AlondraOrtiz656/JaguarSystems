using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarSystems.Models
{
    internal class Producto
    {
        public long IdProductos { get; set; }
        public string Sku { get; set; }
        public string Nombre { get; set; }
        public long DepartamentoId { get; set; }
        public long GrupoId { get; set; }
        public string Unidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Costo { get; set; }
        public decimal Stock { get; set; }
        public decimal StockMin { get; set; }
        public long UbicacionId { get; set; }
        public bool Activo { get; set; }
    }
}
