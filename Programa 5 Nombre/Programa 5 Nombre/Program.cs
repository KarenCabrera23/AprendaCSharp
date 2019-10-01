using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_5_Nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellidos;

            Console.Write("Escribe un nombre:  ");
            nombre = Console.ReadLine();

            Console.Write("Escribe los apellidos:  ");
            apellidos = Console.ReadLine();

            nombre = nombre.ToUpper();
            apellidos = apellidos.ToUpper();

            StringBuilder nombreCompleto = new StringBuilder(nombre);
            nombreCompleto.Append("  ");
            nombreCompleto.Append(apellidos);

            Console.Write(nombreCompleto);

            Console.WriteLine("  ");
            Console.Write("Preciona INTRO para cerrar");
            Console.ReadKey();
        }
    }
}
