using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_6_Tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            string _numero;
            int numero;

            Console.Write("Escoge un numero del 1 al 9 para elaborar la tabla :  ");
            _numero = Console.ReadLine();
            numero = Convert.ToInt32(_numero);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(String.Format("{0}  x  {1} = {2}", numero, i, numero * i));

            }
            Console.WriteLine("");
            Console.WriteLine("Preciona INTRO para cerrar");
            Console.ReadKey();
        }
    }
}
