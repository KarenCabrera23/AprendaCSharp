using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            string valorX;
            int valor = 0;
            Console.Write("Inserta un valor: ");
            valorX = Console.ReadLine();

            if (int.TryParse(valorX, out valor))
            {
                Console.WriteLine(String.Format("El valor {0} es un entero, bien entendido", valor));
            }
            else
            {
                Console.WriteLine("El valor no puede ser un entero. Intenta de nuevo.");
            }
            Console.WriteLine("");
            Console.WriteLine("Preciona INTRO para terminar");
            Console.ReadKey();

        }
    }
}