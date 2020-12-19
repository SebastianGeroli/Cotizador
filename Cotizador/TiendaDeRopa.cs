using System.Collections.Generic;

namespace Cotizador
{
	class TiendaDeRopa {
		private string m_nombre;
		private string m_direccion;
		private List<Prenda> m_prendasParaVender;


		public decimal CalcularCotizacionCamisa(Camisa camisa) {
			decimal resultado;
			resultado = camisa.Precio;

			if (camisa.MangaCorta) {
				resultado = ModificarPrecioEnPorcentaje(resultado,-10) ;
			}

			if (camisa.CuelloMao) {
				resultado *= ModificarPrecioEnPorcentaje(resultado, 3);
			}

			resultado = ModificarPrecioPorCalidad(camisa,resultado);

			return resultado;
		}

		public decimal CalcularCotizacionPantalon(Pantalon pantalon) {
			decimal resultado;
			resultado = pantalon.Precio;

			if (pantalon.Chupin) {
				resultado = ModificarPrecioEnPorcentaje(resultado, -12);
			}

			resultado = ModificarPrecioPorCalidad(pantalon, resultado);

			return resultado;

		}
		private decimal ModificarPrecioPorCalidad(Prenda prenda, decimal precio) {
			
			if (prenda.CalidadPremium) {
				ModificarPrecioEnPorcentaje(precio, 30);
			}
			return precio;
		}
		private decimal ModificarPrecioEnPorcentaje(decimal precio,decimal porcentaje) {
			decimal resultado = precio;

			resultado = resultado * (100 + porcentaje) * 100;

			return resultado;
		}
	}
}