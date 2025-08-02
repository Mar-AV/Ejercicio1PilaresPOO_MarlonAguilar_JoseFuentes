using System;

namespace Ejercicio1PilaresPoo.Clases.Ejercicio1
{
    public class Auditorio : Sala
    {
        public bool TieneEquipoSonido { get; private set; }

        public Auditorio(string nombre, int capacidad, string ubicacion, bool tieneEquipoSonido)
            : base(nombre, capacidad, ubicacion)
        {
            TieneEquipoSonido = tieneEquipoSonido;
        }

        public override bool Reservar(Evento evento, DateTime fechaHora)
        {
            if (evento.Tipo == "Conferencia" && !TieneEquipoSonido)
            {
                Console.WriteLine($"Rechazada: El auditorio {Nombre} no tiene equipo de sonido para una conferencia.");
                return false;
            }
            if (Capacidad < evento.CantidadParticipantes * 2)
            {
                Console.WriteLine($"Rechazada: El auditorio {Nombre} no tiene capacidad suficiente para {evento.CantidadParticipantes * 2} participantes.");
                return false;
            }
            Console.WriteLine($"Reserva confirmada para {Nombre} para el evento {evento.Nombre} el {fechaHora}.");
            return true;
        }

        public override string ObtenerDetalles()
        {
            return $"Auditorio: {Nombre}, Capacidad: {Capacidad}, Ubicación: {Ubicacion}, Equipo de Sonido: {TieneEquipoSonido}";
        }
    }
}