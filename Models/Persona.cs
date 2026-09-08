using System;

public class Persona	
{
    protected int dni;
    protected string nombre;

    public int Dni { get { return Dni; } }
    public string Nombre { get { return Nombre; } }

    public Persona(int dni, string nombre)
	{
        this.dni = dni;
        this.nombre = nombre;
    }

    public virtual string verDatos()
    {
        return $"DNI: {dni}, Nombre: {nombre}";
    }
}
