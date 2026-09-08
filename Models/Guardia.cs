using System;

public class Guardia
{
	private int horaDesde;
	private int minutoDesde;
	private int horaHasta;
	private int minutoHasta;
	private int cantidadMinutos;
	private Policia oficialAsignado;

    public int HoraDesde { get{ return HoraDesde; }
	public int MinutoDesde { get{ return MinutoDesde; }
	public int HoraHasta { get{ return HoraHasta; }
	public int MinutoHasta { get{ return MinutoHasta; }
	public int CantidadMinutos { get{ return CantidadMinutos; }
	public int OficialAsignado { get{ return PoliciaAsignado; }

    public Guardia()
	{

    }

	public void AsignarPolicia(Policia policia, int horaDesde, int minutoDesde, int cantidadMinutos)
	{
		this.oficialAsignado= policia; 
        this.horaDesde = horaDesde;
		this.minutoDesde = minutoDesde;
		this.cantidadMinutos = cantidadMinutos;

		int minutosInicio = horaDesde * 60 + minutoDesde;
		int minutosFin = (minutosInicio + cantidadMinutos);
		this.horaHasta =  (minutosFin / 60)%24;
		this.minutoHasta = minutosFin % 60;
    }
}
