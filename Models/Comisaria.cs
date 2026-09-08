using System;

public class Comisaria
{
	private int cantidadIncidentes;
	private Guardia [] guardias; //0..2 compos
	private Policia [] agentes; //0..2 agregac
	private List <Incidente> incidentes; //0..* compos

    public int CantidadIncidentes { get { return cantidadIncidentes; } }

    public Comisaria ()
	{
		guardias = new Guardia[2];
		incidentes = new List<Incidente>();
		agentes = new Policia[2]; // creamos  referencia no obj
    }

	public bool AsignarPolicia(Policia policia)
	{
			for(int i=0; i<agentes.Length; i++) 
			{
				if(agentes[i] == null) 
				{
					agentes[i] = policia;
					return true;
				}
			}
			return false;    
    }

	public Policia VerAgente(int numeroPlaca) 
	{
		for(int i=0; i<agentes.Length; i++) 
		{
			if(agentes[i] != null && agentes[i].NumeroPlaca == numeroPlaca) 
			{
				return agentes[i];
			}
		}
		return null;
	}

	public void RegistrarIncidente(Policia agente, Persona sujeto, string motivo, int h, int m, int tipoIncidente)
	{
		Incidente nuevoIncidente;
		if (tipoIncidente == 1)
		{
			nuevoIncidente = new Arresto(agente, sujeto, motivo, h, m);
		}

		else if (tipoIncidente == 2)
		{
			nuevoIncidente = new Denuncia(agente, sujeto, motivo, h, m);
		}
		else
		{
			throw new ArgumentException("Tipo de incidente no válido");
        }

        incidentes.Add(nuevoIncidente);
		cantidadIncidentes++;
    }

	public void AsignarGuardia(int numero,int h1,string m1,int tiempoMinutos, Persona agente)
	{
		guardias[numero] = new Guardia(); // compos, creamos obj
        guardias[numero].AsignarPolicia(agente,h1, m1, tiempoMinutos);
    }

	public Incidente VerIncidente(int idx) 
	{
		return incidentes[idx];
    }
}
