using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuevo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();

            av1.mostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Jefatura Madrid", "Sanción de velocidad: 200$", "02-05-16");

            Console.WriteLine(av2.getFecha());

            av2.mostrarAviso();
        }
    }
}
