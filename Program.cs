using System;
using NETCORE.Entidades;

namespace NETCORE
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("DigAcademy", 2000);
            school.Country = "Venezuela";
            school.City = "Punto Fijo";
            Console.WriteLine(school);
        }
    }
}
