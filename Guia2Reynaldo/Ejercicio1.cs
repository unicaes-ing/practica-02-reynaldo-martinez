using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Reynaldo
{
    public class Ejercicio1
    {
        public static void ejer1()
        {
            string nombre;
            Console.WriteLine("Coloque su nombre");
            nombre = Console.ReadLine();
            nombre = nombre.ToLower();
            nombre = nombre.Replace("a", "#");
            nombre = nombre.Replace("e", "%");
            nombre = nombre.Replace("i", "$");
            nombre = nombre.Replace("o", "?");
            nombre = nombre.Replace("u", "*");
            Console.WriteLine(nombre);

        }
    }
}
