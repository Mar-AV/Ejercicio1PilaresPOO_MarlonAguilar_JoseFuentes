using System;

namespace Ejercicio1PilaresPoo.Clases.Ejercicio1
{
    public abstract class Sala
    {
        public string Nombre { get; protected set; }
        public int Capacidad { get; protected set; }
        public string Ubicacion { get; protected set; }

        protected Sala(string nombre, int capacidad, string ubicacion)
        {
            Nombre = nombre;
            Capacidad = capacidad;
            Ubicacion = ubicacion;
        }

        public abstract bool Reservar(Evento evento, DateTime fechaHora);
        public abstract string ObtenerDetalles();
    }
}