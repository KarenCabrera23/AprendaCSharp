using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_8_Compara
{
    class Program
    {
        static void Main(string[] args)
        {
            string _numero1, _numero2;
            int numero1, numero2;

            Console.Write("Numero 1: ");
            _numero1 = Console.ReadLine();

            Console.Write("Numero 2: ");
            _numero2 = Console.ReadLine();

            numero1 = Convert.ToInt32(_numero1);
            numero2 = Convert.ToInt32(_numero2);

            if (numero1 == numero2)
            {
                Console.WriteLine(String.Format("Numeros proporcionados {0} y {1}. {2}",
                    numero1, numero2, "Numeros Iguales"));
            }
            else
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine(String.Format("Numeros proporcionados {0} y {1}. {2}",
                        numero1, numero2, "El primer numero es el mayor"));
                }
                else
                {
                    Console.WriteLine(String.Format("Numeros proporcionados {0} y {1}. {2}",
                        numero1, numero2, "El segundo numero es el mayor"));
                }

            }

            Console.WriteLine("");
            Console.WriteLine("Preciona INTRO para cerrar");
            Console.ReadKey();
        }
    }
}
