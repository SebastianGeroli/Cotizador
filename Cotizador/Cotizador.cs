namespace Cotizador
{
	class Cotizador
	{
		public bool ValidarOperacion(int cantidadUnidadesStock, int cantidadUnidadesACotizar) {
			if (cantidadUnidadesACotizar > cantidadUnidadesStock)
			{
				return true;
			}

			return false;
		}

		public decimal ValidarPrecio(string precio)
		{
			bool exito = decimal.TryParse(precio, out decimal resultado);

			if (exito)
			{
				return resultado;
			}
			else
			{
				return decimal.MaxValue;
			}
		}


		public int ValidarCantidad(string cantidad) {
			bool exito = int.TryParse(cantidad, out int resultado);

			if (exito)
			{
				return resultado;
			}
			else
			{
				return int.MaxValue;
			}
		}


		public void GenerarCotizacion(Vendedor vendedor, Prenda prenda, int cantidadDeUnidadesCotizadas, decimal precioCotizacion)
		{
			Cotizacion cotizacion = new Cotizacion(vendedor.CodigoVendedor, prenda, cantidadDeUnidadesCotizadas, precioCotizacion);
			vendedor.AgregarCotizacion(cotizacion);
		}


		public decimal CalcularCotizacionCamisa(decimal precio, bool mangaCorta, bool cuelloMao, bool premium)
		{
			decimal resultado;
			resultado = precio;

			if (mangaCorta)
			{
				resultado = ModificarPrecioEnPorcentaje(resultado, -10);
			}

			if (cuelloMao)
			{
				resultado = ModificarPrecioEnPorcentaje(resultado, 3);
			}

			resultado = ModificarPrecioPorCalidad(premium, resultado);

			return resultado;
		}


		public decimal CalcularCotizacionPantalon(decimal precio, bool chupin, bool premium)
		{
			decimal resultado;
			resultado = precio;

			if (chupin)
			{
				resultado = ModificarPrecioEnPorcentaje(resultado, -12);
			}

			resultado = ModificarPrecioPorCalidad(premium, resultado);

			return resultado;

		}


		private decimal ModificarPrecioPorCalidad(bool premium, decimal precio)
		{

			if (premium)
			{
				precio = ModificarPrecioEnPorcentaje(precio, 30);
			}
			return precio;
		}


		private decimal ModificarPrecioEnPorcentaje(decimal precio, decimal porcentaje)
		{
			decimal resultado = precio;

			resultado = resultado * (100 + porcentaje) / 100;

			return resultado;
		}
	}
}