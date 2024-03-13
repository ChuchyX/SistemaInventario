using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int CantidadStock { get; set; }

        // Relación con Categoría
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }

        // Relación con Proveedor
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}
