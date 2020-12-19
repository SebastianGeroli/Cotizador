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
		public Prenda GetPrenda (bool isCamisa, bool cuelloMao, bool mangaCorta, bool chupin)
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
							return camisa;
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
							return  pantalon;
						}
					}
				}

			}

			return null;
		}
	}
}