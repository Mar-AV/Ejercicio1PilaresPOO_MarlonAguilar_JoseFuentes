using System;

namespace Ejercicio1PilaresPoo.Clases.Ejercicio1
{
    public class ConferenciaEvento : Evento
{
    public ConferenciaEvento(string nombre, int cantidadParticipantes, string contacto, string notas)
        : base(nombre, "Conferencia", cantidadParticipantes, contacto, notas)
    {
    }
}
}