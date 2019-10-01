using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_3_Aleatorio
{
    class Program
    {
        static public float numeroA = 38.5F;

        static void Main(string[] args)
        {
            float numeroB = 0F;     
            Random numeroAleatorio = new Random();
            numeroB = (float)numeroAleatorio.Next(1, 11);

            Console.WriteLine(String.Format("La suma de {0} y {1} es {2}", numeroA, numeroB, numeroA + numeroB));
            Console.ReadLine();
        }
    }
}
