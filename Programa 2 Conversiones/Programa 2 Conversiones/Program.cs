using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_2_Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeros = "1234";
            Console.WriteLine(numeros.GetType().ToString());

            int intNumeros = Convert.ToInt32(numeros);
            Console.WriteLine(intNumeros.GetType().ToString());

            Console.ReadLine();
        }
    }
}
