using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaDelegado
{
    public static class Program
    {
        delegate  void Reference(string mensaje);
        public delegate double Operacion(double num1, double num2);
        static void Main(string[] args)
        {

            //Reference obj = Console.WriteLine;
            //obj("Hola Mundo");


            ////----------------------------
            //Reference msg = (m) => Console.WriteLine(m);
            //msg("hola lambda");



            ////-----------------------------
            //double num1 = 8;
            //double num2 = 2;
            //Action<double, double> suma = sumar;
            //suma(num1, num2);


            //Func<double, double, double> operacionMultipl = Multiplicar;
            //double resultado = operacionMultipl(num1, num2);

            //Console.WriteLine(string.Format("Multiplicar: {0}", resultado));



            double num1 = 8;
            double num2 = 6;
            Operacion producto = (x, y) => (x * y);
            Operacion suma = (x, y) => (x + y);
            Operacion resta = (a, b) => (a-b);
            double resultado = producto(num1, num2);

            Console.WriteLine("Producto : {0}", resultado);

            Console.WriteLine(suma(num1, 340));



            Console.ReadKey();


        }






        static void sumar(double num1,double num2)
        {
            double resultado = num1 + num2;
            Console.WriteLine(string.Format("sumar: {0}", resultado));
        }

        static double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
