using System;

public class Denuncia : Incidente
{
	public Denuncia(Policia policia, Persona persona, string motivo, int hora, int minuto):base(policia,persona)
	{
		this.Motivo = motivo;
		this.Hora = hora;
		this.Minuto = minuto;
    }

	public string override verDescripcion()
	{
		return $"Denuncia realizada por {Sujeto.Nombre} ante el oficial {OficialACargo.Nombre}. Motivo: {Motivo}. Hora: {Hora}:{Minuto}";
    }
}
