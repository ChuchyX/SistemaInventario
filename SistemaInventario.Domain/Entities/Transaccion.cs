using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Domain.Entities
{
    public class Transaccion
    {
        public int Id { get; set; }     
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }

        // Relación con Producto
        public int ProductoID { get; set; }
        public Producto Producto { get; set; }
    }
}
