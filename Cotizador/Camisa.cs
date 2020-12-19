namespace Cotizador
{
	class Camisa : Prenda {
		private bool m_mangaCorta;
		private bool m_cuelloMao;
		public bool MangaCorta => m_mangaCorta;
		public bool CuelloMao => m_cuelloMao;

		public Camisa(int cantidadDeUnidades, bool mangaCorta = false, bool cuelloMao = false, bool calidadPremium = false, decimal precio = 0):base(cantidadDeUnidades,calidadPremium,precio)
		{
			m_cuelloMao = cuelloMao;
			m_mangaCorta = mangaCorta;
		}
	}
}