using System;

public class Policia : Persona
{
	protected int numeroPlaca;

    public int NumeroPlaca { get { return NumeroPlaca; } }

    public Policia(int dni, string nombre, int numeroPlaca):base(dni, nombre)
    {
        this.numeroPlaca = numeroPlaca;
    }

    public override string verDatos()
    {
        return base.verDatos() + $", Numero de Placa: {numeroPlaca}";
    }
}
