using System.Collections.Generic;

namespace Cotizador
{
	class TiendaDeRopa
	{
		private string m_nombre;
		private string m_direccion;
		private List<Prenda> m_prendasParaVender = new List<Prenda>();

		public string Nombre => m_nombre;
		public string Direccion => m_direccion;
		public List<Prenda> PrendasParaVender => m_prendasParaVender;


		public TiendaDeRopa(string nombre, string direccion, params Prenda[] prendas)
		{
			m_nombre = nombre;
			m_direccion = direccion;

			foreach (var prenda in prendas)
			{
				AgregarPrenda(prenda);
			}
		}


		public void AgregarPrenda(Prenda prenda)
		{
			m_prendasParaVender.Add(prenda);
		}

		public void QuitarPrenda(Prenda prenda)
		{
			if (m_prendasParaVender.Contains(prenda))
			{
				m_prendasParaVender.Remove(prenda);
			}
		}

		public int GetStock(bool isCamisa, bool cuelloMao, bool mangaCorta, bool chupin)
		{
			int result = 0;
			if (isCamisa)
			{
				foreach (var prenda in m_prendasParaVender)
				{
					Camisa camisa;
					try
					{
						camisa = (Camisa)prenda;
					}
					catch (System.InvalidCastException)
					{
						camisa = null;
					}

					if (camisa != null)
					{
						if (camisa.CuelloMao == cuelloMao && camisa.MangaCorta == mangaCorta)
						{
							return result = camisa.CantidadDeUnidades;
						}
					}
				}

			}
			else
			{
				foreach (var prenda in m_prendasParaVender)
				{
					Pantalon pantalon;
					try
					{
						pantalon = (Pantalon)prenda;
					}
					catch (System.InvalidCastException)
					{
						pantalon = null;
					}

					if (pantalon != null)
					{
						if (pantalon.Chupin == chupin)
						{
							return result = pantalon.CantidadDeUnidades;
						}
					}
				}

			}

			return result;
		}


		public decimal CalcularCotizacionCamisa(Camisa camisa)
		{
			decimal resultado;
			resultado = camisa.Precio;

			if (camisa.MangaCorta)
			{
				resultado = ModificarPrecioEnPorcentaje(resultado, -10);
			}

			if (camisa.CuelloMao)
			{
				resultado *= ModificarPrecioEnPorcentaje(resultado, 3);
			}

			resultado = ModificarPrecioPorCalidad(camisa, resultado);

			return resultado;
		}

		public decimal CalcularCotizacionPantalon(Pantalon pantalon)
		{
			decimal resultado;
			resultado = pantalon.Precio;

			if (pantalon.Chupin)
			{
				resultado = ModificarPrecioEnPorcentaje(resultado, -12);
			}

			resultado = ModificarPrecioPorCalidad(pantalon, resultado);

			return resultado;

		}
		private decimal ModificarPrecioPorCalidad(Prenda prenda, decimal precio)
		{

			if (prenda.CalidadPremium)
			{
				ModificarPrecioEnPorcentaje(precio, 30);
			}
			return precio;
		}
		private decimal ModificarPrecioEnPorcentaje(decimal precio, decimal porcentaje)
		{
			decimal resultado = precio;

			resultado = resultado * (100 + porcentaje) * 100;

			return resultado;
		}
	}
}