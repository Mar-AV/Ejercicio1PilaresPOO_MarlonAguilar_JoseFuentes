using System;

namespace Ejercicio1PilaresPoo.Clases.Ejercicio1
{
    public class SalaComun : Sala
    {
        public bool TieneProyector { get; private set; }

        public SalaComun(string nombre, int capacidad, string ubicacion, bool tieneProyector)
            : base(nombre, capacidad, ubicacion)
        {
            TieneProyector = tieneProyector;
        }

        public override bool Reservar(Evento evento, DateTime fechaHora)
        {
            if (evento.Tipo == "Conferencia" && !TieneProyector)
            {
                Console.WriteLine($"Rechazada: La sala {Nombre} no tiene proyector para una conferencia.");
                return false;
            }
            if (Capacidad < evento.CantidadParticipantes)
            {
                Console.WriteLine($"Rechazada: La sala {Nombre} no tiene capacidad suficiente ({Capacidad} < {evento.CantidadParticipantes}).");
                return false;
            }
            Console.WriteLine($"Reserva confirmada para {Nombre} para el evento {evento.Nombre} el {fechaHora}.");
            return true;
        }

        public override string ObtenerDetalles()
        {
            return $"Sala Común: {Nombre}, Capacidad: {Capacidad}, Ubicación: {Ubicacion}, Proyector: {TieneProyector}";
        }
    }
}