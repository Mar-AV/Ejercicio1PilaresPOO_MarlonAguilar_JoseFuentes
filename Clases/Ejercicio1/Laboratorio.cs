using System;

namespace Ejercicio1PilaresPoo.Clases.Ejercicio1
{
    public class Laboratorio : Sala
    {
        public int NumeroComputadoras { get; private set; }

        public Laboratorio(string nombre, int capacidad, string ubicacion, int numeroComputadoras)
            : base(nombre, capacidad, ubicacion)
        {
            NumeroComputadoras = numeroComputadoras;
        }

        public override bool Reservar(Evento evento, DateTime fechaHora)
        {
            if (evento.Tipo == "Práctica" && NumeroComputadoras < evento.CantidadParticipantes)
            {
                Console.WriteLine($"Rechazada: El laboratorio {Nombre} no tiene suficientes computadoras ({NumeroComputadoras} < {evento.CantidadParticipantes}).");
                return false;
            }
            if (Capacidad < evento.CantidadParticipantes)
            {
                Console.WriteLine($"Rechazada: El laboratorio {Nombre} no tiene capacidad suficiente ({Capacidad} < {evento.CantidadParticipantes}).");
                return false;
            }
            Console.WriteLine($"Reserva confirmada para {Nombre} para el evento {evento.Nombre} el {fechaHora}.");
            return true;
        }

        public override string ObtenerDetalles()
        {
            return $"Laboratorio: {Nombre}, Capacidad: {Capacidad}, Ubicación: {Ubicacion}, Computadoras: {NumeroComputadoras}";
        }
    }
}