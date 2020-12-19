namespace Cotizador
{
	class Pantalon : Prenda
	{
		private bool m_chupin;
		public bool Chupin => m_chupin;

		public Pantalon(int cantidadDeUnidades, bool chupin = false, bool calidadPremium = false, decimal precio = 0) : base(cantidadDeUnidades, calidadPremium, precio)
		{
			m_chupin = chupin;
		}
	}
}