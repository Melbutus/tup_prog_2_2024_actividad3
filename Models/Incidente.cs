using System;

public abstract class Incidente
{
	private string motivo;
	private int hora;
	private int minuto;
	private Policia oficialACargo;
	private Persona sujeto;

    public string Motivo { get; set; }
	public int Hora { get; set; }
	public int Minuto { get; set; }

	public Policia OficialACargo { get { return OficialACargo} };
	public Persona Sujeto { get { return Sujeto} };

    public Incidente(Policia oficial, Persona sujeto)
	{
		this.oficialACargo = oficial;
		this.sujeto= sujeto;
    }

	public abstract string verDescripcion();
}
