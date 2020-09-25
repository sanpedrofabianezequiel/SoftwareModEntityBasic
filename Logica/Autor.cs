using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Autor
    {
        Datos.Autor objdatos = new Datos.Autor();
        //Aca va la logica de Negocio
        public void Agregar(Modelo.Autor autor)
        {
            //USAMOS un Objeto de la CAPA DE DATOS
            objdatos.Agregar(autor);
        }



        public void Modificar(Modelo.Autor autorR)
        {
            //USAMOS un Objeto de la CAPA DE DATOS

            objdatos.Modificar(autorR);
        }


        public List<Modelo.Autor> TraerTodos()
        {
            //USAMOS un Objeto de la CAPA DE DATOS

            return objdatos.TraerTodos();
        }

        public void Borrar(int id)
        {
            //USAMOS un Objeto de la CAPA DE DATOS

            objdatos.Borrar(id);
        }


        public List<Modelo.Autor> TraerTodos(string letras)
        {
            //USAMOS un Objeto de la CAPA DE DATOS

            return objdatos.TraerTodos(letras);
        }

    }
}
