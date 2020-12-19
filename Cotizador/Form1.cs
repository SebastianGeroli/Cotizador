using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotizador
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		TiendaDeRopa tiendaDeRopa;
		private void Form1_Load(object sender, EventArgs e)
		{
			//Generar prendas
			Camisa camisaMangaCortaNormal = new Camisa(300, true, false);//Camisa manga corta normal con stock de 300
			Camisa camisaMangaCortaMao = new Camisa(200, true, true);//Camisa manga corta cuello mao con stock de 200
			Camisa camisaMangaLargaNormal = new Camisa(350, false, false);//Camisa manga larga normal con stock de 350
			Camisa camisaMangaLargaMao = new Camisa(150, false, true);//Camisa manga larga cuello mao con stock de 150

			Pantalon pantalonChupin = new Pantalon(1500, true);//Pantalon Chupin con stock de 1500
			Pantalon pantalonNormal = new Pantalon(500);//Pantalon Normal con stock de 500

			//Instanciacion tienda de Ropa con el listado  de prendas a vender disponible
			tiendaDeRopa = new TiendaDeRopa(
				"Expresso",
				"Juan B. Justo 1500",
				camisaMangaCortaNormal,
				camisaMangaCortaMao,
				camisaMangaLargaNormal,
				camisaMangaLargaMao,
				pantalonChupin,
				pantalonNormal
			);
		}

		private void radioBtnCamisa_CheckedChanged(object sender, EventArgs e)
		{
			UpdateStockLabel();
		}

		private void UpdateStockLabel() { 
			lblValorStock.Text = tiendaDeRopa.GetStock(radioBtnCamisa.Checked, checkBoxCuelloMao.Checked, checkBoxMangaCorta.Checked, checkBoxChupin.Checked).ToString();
		}

		private void radioBtnPantalon_CheckedChanged(object sender, EventArgs e)
		{
			UpdateStockLabel();
		}

		private void checkBoxMangaCorta_CheckedChanged(object sender, EventArgs e)
		{
			UpdateStockLabel();
		}

		private void checkBoxCuelloMao_CheckedChanged(object sender, EventArgs e)
		{
			UpdateStockLabel();
		}

		private void checkBoxChupin_CheckedChanged(object sender, EventArgs e)
		{
			UpdateStockLabel();
		}
	}
}
