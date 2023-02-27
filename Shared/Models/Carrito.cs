using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaProyecto.Shared.Models
{
    public class Carrito
    {
        public List<Libro> Libros { get; set; } = new List<Libro>();
        public decimal Total => (decimal)Libros.Sum(l => l.Precio);
    }


}
