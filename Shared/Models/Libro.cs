using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaProyecto.Shared.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Imagen { get; set; }
        public float Precio { get; set; }
        
        public int Edicion { get; set; }
        public string ISBN{ get; set; }
        public string Editorial { get; set; }


    }
}
