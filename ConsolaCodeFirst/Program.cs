using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            Modelo.Contexto db = new Modelo.Contexto();
            Modelo.Autor objAutor = new Modelo.Autor();
            Logica.Autor objLogicaAutor = new Logica.Autor();

            #region comentarios
            //El id lo pone solo no hace falta ponerlo
            //objAutor.Apellido = "Donoso";
            // objAutor.Nombre = "Yamila";


            // //Trabajamos con las clases
            // db.Autores.Add(objAutor);
            // db.SaveChanges();
            // //Despues de agregar todo y crear la base me tira el console
            //// Console.WriteLine("Autor Agregado");

            //objAutor.Apellido = "San Pedro";
            //objAutor.Nombre = "Fabian";
            //objLogicaAutor.Agregar(objAutor);

            //Console.WriteLine("Autor Agregado");

            #endregion
            Console.WriteLine("Lista de autores");
            //Traemos de la logica el metodo que traiga la lista ose ala 
            //Coleccion de AUTORES con SU METODO TRAGA TODO

            foreach (var item in objLogicaAutor.TraerTodos() )
            {
                Console.WriteLine("Autor {0},{1}",item.Nombre,item.ID);
            }

            Console.ReadKey();
        }
    }
}
