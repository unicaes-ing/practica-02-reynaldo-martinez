using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Reynaldo
{
    public class Ejercicio5
    {
        public static void ejer5()
        {
            string num;
            double total = 0, valMinuto=0;
            DateTime minutos, hInicio, hFin;
            Console.WriteLine("Coloque el numero de telefono");
            num = Console.ReadLine();
            Console.WriteLine("Coloque la hora de inicio en el siguiente formato \"hora:minutos");
            hInicio = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Coloque la hora de fin en el siguiente formato \"hora:minutos");
            hFin = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Coloque el valor por minuto de la llamada");
            valMinuto = Convert.ToDouble(Console.ReadLine());
            total = hFin.Subtract(hInicio).Minutes * valMinuto;
            Console.WriteLine("La cantidad de minutos transcurridos es: " + hFin.Subtract(hInicio).Minutes);
            Console.WriteLine("El costo por minuto es de: $" + valMinuto);
            Console.WriteLine("El total de la llamada es: $" + total.ToString("N2"));



        }
    }
}