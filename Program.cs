using System;
using NETCORE.Entidades;

namespace NETCORE
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("DigAcademy", 2000);
            escuela.Pais = "Venezuela";
            escuela.Ciudad = "Punto Fijo";
            Console.WriteLine(escuela.Nombre);
        }
    }
}
