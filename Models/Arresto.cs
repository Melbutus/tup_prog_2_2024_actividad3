using System;

public class Arresto:Incidente
{
	public Arresto(Policia policia, Persona sujeto, string motivo, int hora, int minuto):base(policia, sujeto)
	{
		this.Motivo = motivo;
        this.Hora = hora;
		this.Minuto = minuto;
	}

	public string override verDescripcion()
	{
		return $"Arresto realizado por {Sujeto.Nombre} ante el oficial {OficialACargo.Nombre}. Motivo: {Motivo}. Hora: {Hora}:{Minuto}";
    }
}
