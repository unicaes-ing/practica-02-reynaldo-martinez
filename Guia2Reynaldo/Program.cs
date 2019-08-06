using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Reynaldo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            Console.WriteLine("que ejercicio desea ver?");
            opc = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opc)
            {
                case 1:
                    Ejercicio1.ejer1();
                    break;
                case 2:
                    Ejercicio2.ejer2();
                    break;
                case 3:
                    Ejercicio3.ejer3();
                    break;
                case 4:
                    Ejercicio4.ejer4();
                    break;
                case 5:
                    Ejercicio5.ejer5();
                    break;
                case 6:
                    Ejercicio6.ejer6();
                    break;
                default:
                    break;
            }
            Console.ReadKey();

        }
    }
}
