using System;

namespace Ejercicio1PilaresPoo.Clases.Ejercicio1
{
    public class PracticaEvento : Evento
{
    public PracticaEvento(string nombre, int cantidadParticipantes, string contacto, string notas)
        : base(nombre, "Práctica", cantidadParticipantes, contacto, notas)
    {
    }
}
}