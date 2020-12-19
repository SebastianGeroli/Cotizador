namespace Cotizador
{
	class Prenda
	{
		protected decimal precio;
		protected bool calidadPremium;
		protected int cantidadDeUnidades;

		public decimal Precio => precio;
		public bool CalidadPremium => calidadPremium;
		public int CantidadDeUnidades => cantidadDeUnidades;


		public Prenda(int cantidadDeUnidades, bool calidadPremium = false, decimal precio = 0) {
			this.calidadPremium = calidadPremium;
			this.cantidadDeUnidades = cantidadDeUnidades;
			this.precio = precio;
		}

	}
}