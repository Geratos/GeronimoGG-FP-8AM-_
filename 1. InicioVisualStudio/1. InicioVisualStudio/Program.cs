using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion e inicializacion de variables
            string nombre = "Geronimo";
            const string iva = " 19% ";
            string apellidos = "Giraldo Giraldo";
            //no puedo cambiar el valor de iva pq es una constante
            Console.Write(" pinga\n ");
            Console.Write("\t" +   nombre + " " + apellidos + " " + iva);
            Console.ReadKey();
        }
    }
}
