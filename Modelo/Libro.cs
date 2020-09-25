using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Libro
    {
        [Key]
        public int ID { get; set; }
        public string Titulo { get; set; }
        public int Año { get; }
        public List<Autor> autores { get; set; }

    }
}
