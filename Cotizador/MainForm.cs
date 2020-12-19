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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		TiendaDeRopa tiendaDeRopa;
		Vendedor vendedor = new Vendedor("Jhon", "Doe", "0123456789");
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

			//Labels
			lblDireccionTienda.Text = tiendaDeRopa.Direccion;
			lblNombreTienda.Text = tiendaDeRopa.Nombre;
			lblNombreVendedor.Text = $"{vendedor.Nombre} {vendedor.Apellido}";

			UpdateStockLabel();
		}

		private void radioBtnCamisa_CheckedChanged(object sender, EventArgs e)
		{
			UpdateStockLabel();
		}

		//Con cada cambio que sucede vuelve a buscar si la tienda tiene una prenda que coincida con la busqueda, caso de encontrarla le pasamos al label el valor de stock
		private void UpdateStockLabel()
		{
			Prenda prendaEncontrada = tiendaDeRopa.GetPrenda(radioBtnCamisa.Checked, checkBoxCuelloMao.Checked, checkBoxMangaCorta.Checked, checkBoxChupin.Checked);
			if (prendaEncontrada != null)
			{
				lblValorStock.Text = tiendaDeRopa.GetPrenda(radioBtnCamisa.Checked, checkBoxCuelloMao.Checked, checkBoxMangaCorta.Checked, checkBoxChupin.Checked).CantidadDeUnidades.ToString();
			}
			else
			{
				lblValorStock.Text = "0";
			}

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

		private void btnCotizar_Click(object sender, EventArgs e)
		{
			Cotizador cotizador = new Cotizador();// iniciar el cotizador

			decimal precioUnitario = cotizador.ValidarPrecio(textBoxPrecio.Text);//validacion del dato dentro del textbox
			int cantidad = cotizador.ValidarCantidad(textBoxCantidad.Text);//validacion del dato dentro del texbox

			decimal cotizacion = 0;//Resultado final al pasar por la cotizacion

			//Se busca la prenda dentro del listado de la tienda para luego guardar su referencia en la cotizacion
			Prenda prendaEncontrada = tiendaDeRopa.GetPrenda(radioBtnCamisa.Checked, checkBoxCuelloMao.Checked, checkBoxMangaCorta.Checked, checkBoxChupin.Checked);

			int stock = 0;//stock usado para comparar mas adelante si la operacion es valida
			if (prendaEncontrada != null)
			{
				stock = tiendaDeRopa.GetPrenda(radioBtnCamisa.Checked, checkBoxCuelloMao.Checked, checkBoxMangaCorta.Checked, checkBoxChupin.Checked).CantidadDeUnidades;
			}

			//Si alguna de las validaciones fallo mostrar un mensaje de error
			if (precioUnitario == decimal.MaxValue || cantidad == int.MaxValue)
			{
				lblCotizacionFinal.Text = " - - - ";
				MessageBox.Show("Error: Precio unitario y cantidad deben ser numeros");

			}
			else
			{
				cotizacion = cotizador.Cotizar(precioUnitario, cantidad, radioBtnCamisa.Checked, checkBoxMangaCorta.Checked, checkBoxCuelloMao.Checked, checkBoxChupin.Checked, radioButtonPremium.Checked, vendedor, prendaEncontrada);


				if (cotizacion == decimal.MaxValue)
				{
					lblCotizacionFinal.Text = " - - - ";
					MessageBox.Show("Operacion invalida: La cantidad de objetos a cotizar es mayor al stock");
				}
				else
				{
					lblCotizacionFinal.Text = cotizacion.ToString();
				}
			}

		}

		private void lblHistorialCotizacion_Click(object sender, EventArgs e)
		{
			string message = "";

			//Preparado del message a pasar al form que mostrara todas las cotizaciones
			foreach (var cotizacion in vendedor.HistorialDeCotizaciones)
			{
				message += $"Cotizacion Numero: {cotizacion.NumeroIdentificacion} \n";
				message += $"Fecha de Creacion: {cotizacion.Fecha} \n";
				message += $"Codigo Vendedor: {cotizacion.CodigoVendedor} \n";
				message += $"Prenda Cotizada: {cotizacion.PrendaCotizada} \n";
				message += $"Cantidad De unidades Cotizadas: {cotizacion.CantidadDeUnidades} \n";
				message += $"Resultado Cotizacion: {cotizacion.ResultadoCotizacion} \n";
				message += $"########## \n";
				message += $" \n";


			}

			CotizacionesForm cotizacionesForm = new CotizacionesForm();
			cotizacionesForm.SetTextBox(message.Replace("\n", Environment.NewLine));//Reemplazo de \n por newline ya que en el textbox falla el formateo
			cotizacionesForm.Show();

		}
	}
}
