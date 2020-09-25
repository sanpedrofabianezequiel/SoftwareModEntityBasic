using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto : DbContext   //Usamos el Entity
    {

        //LLamo al construcror de la base
        public Contexto(): base("CadenaConexion")
        {

        }


        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
    }
}
