using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Reynaldo
{
    public class Ejercicio4
    {
        public static void ejer4()
        {
            DateTime fechaInicio, fechaEntrega;
            double valorDia = 0, total = 0;
            

            Console.WriteLine("Coloque la fecha de inicio");
            fechaInicio = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Coloque la fecha de entrega al dueno");
            fechaEntrega = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Coloque el precio por dia");
            valorDia = Convert.ToDouble(Console.ReadLine());
            total = fechaEntrega.Subtract(fechaInicio).Days * valorDia;
            Console.WriteLine("Dias transcurridos: " + fechaEntrega.Subtract(fechaInicio).Days);
            Console.WriteLine("Precio por dia: " + valorDia);
            Console.WriteLine("Total a pagar: $" + total.ToString("N2"));
            
        }
    }
}
