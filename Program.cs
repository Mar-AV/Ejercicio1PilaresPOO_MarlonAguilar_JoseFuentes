using Ejercicio1PilaresPoo.Clases.Ejercicio1;
using System;

namespace Ejercicio1PilaresPoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona el ejercicio a ejecutar:");
            Console.WriteLine("1. Ejercicio de Reserva de Salas");

            string opcion = Console.ReadLine();

            // Verificación básica para evitar null
            if (string.IsNullOrEmpty(opcion))
            {
                Console.WriteLine("Opción no válida.");
                return;
            }

            switch (opcion)
            {
                case "1":
                    Ejercicio1.Ejecutar();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}