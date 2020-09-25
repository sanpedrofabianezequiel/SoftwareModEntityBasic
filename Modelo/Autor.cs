using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{

    
    [Table("Autores")]//Cambiamos el nombre de la tabla
    public class Autor
    {
        [Key]
        public int ID { get; set; }
        public string Apellido { get; set; }

        public string Nombre { get; set; }


    }
}
