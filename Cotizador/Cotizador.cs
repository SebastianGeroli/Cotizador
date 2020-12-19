namespace Cotizador
{
	class Cotizador
	{

		public decimal Cotizar(decimal precioUnitario, int cantidadACotizar, bool esCamisa, bool mangaCorta, bool cuelloMao, bool chupin, bool premium, Vendedor vendedor, Prenda prenda)
		{

			decimal cotizacion = 0;

			//Validar operacion caso de fallar devolver valor maximo.
			if (ValidarOperacion(prenda.CantidadDeUnidades, cantidadACotizar) == false)
			{
				return decimal.MaxValue;
			}

			if (esCamisa)
			{
				cotizacion = CalcularCotizacionCamisa(precioUnitario, mangaCorta, cuelloMao, premium);
			}
			else
			{
				cotizacion = CalcularCotizacionPantalon(precioUnitario, chupin, premium);
			}

			cotizacion *= cantidadACotizar;

			GenerarCotizacion(vendedor, prenda, cantidadACotizar, cotizacion);

			return cotizacion;
		}

		//Genera la instancia de cotizacion y lo agrega a la lista de cotizaciones del vendedor
		public void GenerarCotizacion(Vendedor vendedor, Prenda prenda, int cantidadDeUnidadesCotizadas, decimal precioCotizacion)
		{
			Cotizacion cotizacion = new Cotizacion(vendedor.CodigoVendedor, prenda, cantidadDeUnidadesCotizadas, precioCotizacion);
			vendedor.AgregarCotizacion(cotizacion);
		}

		//Calcula segun las formulas para las camisas
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

		//Calcula segun las formulas para los pantalones
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

		//Modifica el precio segun la calidad
		private decimal ModificarPrecioPorCalidad(bool premium, decimal precio)
		{

			if (premium)
			{
				precio = ModificarPrecioEnPorcentaje(precio, 30);
			}
			return precio;
		}

		//Facilita la utilidad de calculos por porcentaje
		private decimal ModificarPrecioEnPorcentaje(decimal precio, decimal porcentaje)
		{
			decimal resultado = precio;

			resultado = resultado * (100 + porcentaje) / 100;

			return resultado;
		}

		/// <summary>
		/// Valida la operacion si el numero de stock es mayor a la cantidad a cotizar devuelve true
		/// </summary>
		/// <param name="cantidadUnidadesStock"></param>
		/// <param name="cantidadUnidadesACotizar"></param>
		/// <returns></returns>
		public bool ValidarOperacion(int cantidadUnidadesStock, int cantidadUnidadesACotizar)
		{
			if (cantidadUnidadesStock >= cantidadUnidadesACotizar)
			{
				return true;
			}

			return false;
		}


		/// <summary>
		/// Devuelve el valor del string pasado en decimal, en caso de fallo devuelve maxvalue
		/// </summary>
		/// <param name="precio"></param>
		/// <returns></returns>
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

		/// <summary>
		/// Devuelve el valor del string pasado a int, en caso de fallo devuelve maxvalue
		/// </summary>
		/// <param name="cantidad"></param>
		/// <returns></returns>
		public int ValidarCantidad(string cantidad)
		{
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

	}
}