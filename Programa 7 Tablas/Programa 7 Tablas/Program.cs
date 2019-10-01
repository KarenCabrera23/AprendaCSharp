using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_7_Tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(String.Format("Tabla del {0}: ", i));
                Console.WriteLine();

                for (int a = 1; a <= 10; a++)
                {
                    Console.WriteLine(String.Format("{0} x {1} = {2}", i, a, i * a));
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Preciona INTRO para cerrar");
            Console.ReadKey();
        }
    }
}
