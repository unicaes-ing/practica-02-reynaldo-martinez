using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Reynaldo
{
    public class Ejercicio2
    {
        public static void ejer2()
        {
            string nProducto;
            int cantidad = 0;
            double precio = 0, subtotal = 0, iva=0, total=0;
            Console.WriteLine("Coloque el nombre del producto");
            nProducto = Console.ReadLine();
            Console.WriteLine("Coloque la cantidad de productos que lleva");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Coloque el precio del producto");
            precio = Convert.ToDouble(Console.ReadLine());
            subtotal= cantidad * precio;
            iva = subtotal * 0.03;
            total = subtotal + iva;
            Console.WriteLine("El subtotal es: " +subtotal.ToString("C2"));
            Console.WriteLine("El total es: " + total.ToString("C2"));

        }
    }
}
