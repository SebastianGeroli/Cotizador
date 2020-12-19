using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador
{
	class Vendedor
	{
		private string m_nombre;
		private string m_apellido;
		private string m_codigoVendedor;
		private List<Cotizacion> HistorialDeCotizaciones = new List<Cotizacion>();

		public string Nombre => m_nombre;
		public string Apellidp => m_apellido;
		public string CodigoVendedor => m_codigoVendedor;

		public Vendedor(string nombre, string apellido, string codigoVendedor) {
			m_nombre = nombre;
			m_apellido = apellido;
			m_codigoVendedor = codigoVendedor;
		}
	}
}
