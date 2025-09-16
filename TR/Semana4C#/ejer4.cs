using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Semana4C_
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            Console.Write("Bienvenido a el Calculo de área\n");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Redtangulo");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Circulo");
            Console.Write("\nIngrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {
                case 1:Console.Write("\nIngrese un lado: ");
                    int lado = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea:" + (lado * lado));
                    break;
                case 2:
                    Console.Write("\nIngrese un base: ");
                    int bse = int.Parse(Console.ReadLine());
                    Console.Write("\nIngrese un altura: ");
                    int alt = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea:" + (bse * alt));
                    break;
                case 3:
                    Console.Write("\nIngrese un base: ");
                    int bse2 = int.Parse(Console.ReadLine());
                    Console.Write("\nIngrese un altura: ");
                    int alt2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea:" + ((bse2 * alt2)/2));
                    break;
                case 4:
                    Console.Write("\nIngrese la radio: ");
                    double radio = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nÁrea:" + Math.Round(Math.PI * (radio*radio),2));
                    break;
                default:
                    Console.Write("\nOpción incorrecta");
                    break;
            }

        }
    }
}
