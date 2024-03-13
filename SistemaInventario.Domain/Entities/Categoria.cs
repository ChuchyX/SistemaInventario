using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Domain.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Relación con Producto
        public ICollection<Producto> Productos { get; set; }
    }
}
