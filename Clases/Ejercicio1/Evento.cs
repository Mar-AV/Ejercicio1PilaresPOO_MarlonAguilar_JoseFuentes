using System;

namespace Ejercicio1PilaresPoo.Clases.Ejercicio1
{
    public abstract class Evento
{
    public string Nombre { get; protected set; }
    public string Tipo { get; protected set; }
    public int CantidadParticipantes { get; protected set; }
    private string ContactoOrganizador { get; set; }
    private string NotasPrivadas { get; set; }

    protected Evento(string nombre, string tipo, int cantidadParticipantes, string contacto, string notas)
    {
        Nombre = nombre;
        Tipo = tipo;
        CantidadParticipantes = cantidadParticipantes;
        ContactoOrganizador = contacto;
        NotasPrivadas = notas;
    }
}
}