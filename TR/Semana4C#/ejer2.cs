using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4C_
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar año: ");
            int annio = int.Parse(Console.ReadLine());

            if (annio % 4 == 0 && annio % 100 != 0 || annio % 400==0)
            {
                Console.WriteLine("Año Bisiesto");
            }
            else
            {
                Console.WriteLine("Año No Bisiesto");
            }
            if(annio % 2==0)
            {
                Console.WriteLine("Año Par");
            }
            else
            {
                Console.WriteLine("Año Impar");
            }
            Console.ReadKey();
        }
    }
}
