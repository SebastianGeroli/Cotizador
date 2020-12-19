using System;
namespace Cotizador
{
	class Cotizacion
	{
		private int m_numeroIdentificacion;
		private string m_fecha;
		private string m_codigoVendedor;
		private Prenda m_prendaCotizada;
		private int m_cantidadDeUnidades;
		private decimal m_resultadoCotizacion;

		static int CantidadDeCotizaciones = 0;

		public int NumeroIdentificacion => m_numeroIdentificacion;
		public string Fecha => m_fecha;
		public string CodigoVendedor => m_codigoVendedor;
		public Prenda PrendaCotizada => m_prendaCotizada;
		public int CantidadDeUnidades => m_cantidadDeUnidades;
		public decimal ResultadoCotizacion => m_resultadoCotizacion;

		public Cotizacion(string codigoVendedor, Prenda prendaCotizada, int cantidadDeunidades, decimal resultadoCotizacion)
		{
			m_numeroIdentificacion = CantidadDeCotizaciones;
			DateTime dateTime = DateTime.Now;
			m_fecha = dateTime.ToString("dd/MM/yyyy HH:mm:ss");
			m_codigoVendedor = codigoVendedor;
			m_prendaCotizada = prendaCotizada;
			m_cantidadDeUnidades = cantidadDeunidades;
			m_resultadoCotizacion = resultadoCotizacion;
			CantidadDeCotizaciones++;
		}
	}
}