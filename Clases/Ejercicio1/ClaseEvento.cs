using System;

namespace Ejercicio1PilaresPoo.Clases.Ejercicio1
{
    public class ClaseEvento : Evento
{
    public ClaseEvento(string nombre, int cantidadParticipantes, string contacto, string notas)
        : base(nombre, "Clase", cantidadParticipantes, contacto, notas)
    {
    }
}
}