using System;

namespace Ejercicio1PilaresPoo.Clases.Ejercicio1
{
    public class Ejercicio1
    {
        public static void Ejecutar()
        {
            // Crear instancias de salas
            Sala salaComun = new SalaComun("Sala A", 30, "Edificio 1", true);
            Sala auditorio = new Auditorio("Auditorio Principal", 100, "Edificio 2", true);
            Sala laboratorio = new Laboratorio("Lab 101", 20, "Edificio 3", 15);

            // Crear instancias de eventos
            Evento clase = new ClaseEvento("Matemáticas 101", 25, "juan@univ.edu", "Revisar ecuaciones");
            Evento conferencia = new ConferenciaEvento("Conferencia IA", 80, "maria@univ.edu", "Preparar equipo");
            Evento practica = new PracticaEvento("Programación II", 18, "carlos@univ.edu", "Usar computadoras");

            // Usar la fecha actual + 1 día (domingo 3 de agosto de 2025 a las 04:38 PM CST)
            DateTime fecha = DateTime.Now.AddDays(1); // Ajusta a mañana a la misma hora

            // Intentar reservar
            salaComun.Reservar(clase, fecha);
            auditorio.Reservar(conferencia, fecha);
            laboratorio.Reservar(practica, fecha);

            // Mostrar detalles de las salas
            Console.WriteLine("\nDetalles de las salas:");
            Console.WriteLine(salaComun.ObtenerDetalles());
            Console.WriteLine(auditorio.ObtenerDetalles());
            Console.WriteLine(laboratorio.ObtenerDetalles());
        }
    }
}