using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Autor
    {

        //METODOS CRUD
        //Vamos a insetar lo que recivamos de LOGICA
        //Es lo que tengo mapiado
        Modelo.Contexto _context = new Modelo.Contexto();
        public void Agregar(Modelo.Autor autor)
        {

            _context.Autores.Add(autor);//En memoria
            _context.SaveChanges();//Persistimos en la BD
        }

        public void Modificar (Modelo.Autor autorR)
        {
            
            Modelo.Autor autorActual = _context.Autores.Find(autorR.ID);
            autorActual.ID = autorR.ID;
            autorActual.Apellido = autorR.Apellido;
            autorActual.Nombre = autorR.Nombre;

            //Persistimos los cambios
            _context.SaveChanges();


        }
        public List<Modelo.Autor> TraerTodos()
        {
            List<Modelo.Autor> lista = new List<Modelo.Autor>();

            //LINQ
            //Llamamos a nuestro _context que tiene el accecio a la BD Y las TABLAS
            lista = (from a in _context.Autores
                    select a).ToList();
            ////OTRA OPCION
            //var lista2 = (from a in _context.Autores
            //             select a);
            //return lista2.ToList();

            return lista;
        }


        public List<Modelo.Autor> TraerTodos(string letras)
        {
            List<Modelo.Autor> lista = new List<Modelo.Autor>();

            //LINQ
            //Llamamos a nuestro _context que tiene el accecio a la BD Y las TABLAS

            //OTRA OPCION
            var lista2 = (from a in _context.Autores
                          where a.Apellido.Contains(letras)//Buscamos ese dato
                         select a);
            return lista2.ToList();

            
        }

        public void Borrar(int id)
        {
            Modelo.Autor autorDelete = _context.Autores.Find(id);

            //Acemos el delete en el Objeto que le pega a la COLECCION Y dsp PERSISTO
            _context.Autores.Remove(autorDelete);
            _context.SaveChanges();
        }



    }
}
