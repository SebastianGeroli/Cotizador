
namespace Cotizador
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblNombreTienda = new System.Windows.Forms.Label();
			this.lblDireccionTienda = new System.Windows.Forms.Label();
			this.lblNombreVendedor = new System.Windows.Forms.Label();
			this.lblHistorialCotizacion = new System.Windows.Forms.Label();
			this.radioBtnCamisa = new System.Windows.Forms.RadioButton();
			this.radioBtnPantalon = new System.Windows.Forms.RadioButton();
			this.checkBoxMangaCorta = new System.Windows.Forms.CheckBox();
			this.checkBoxCuelloMao = new System.Windows.Forms.CheckBox();
			this.checkBoxChupin = new System.Windows.Forms.CheckBox();
			this.labelStock = new System.Windows.Forms.Label();
			this.lblValorStock = new System.Windows.Forms.Label();
			this.radioButtonStandard = new System.Windows.Forms.RadioButton();
			this.radioButtonPremium = new System.Windows.Forms.RadioButton();
			this.groupBoxCalidad = new System.Windows.Forms.GroupBox();
			this.groupBoxPrenda = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxStock = new System.Windows.Forms.GroupBox();
			this.groupBoxPrecioYCantidad = new System.Windows.Forms.GroupBox();
			this.textBoxPrecio = new System.Windows.Forms.TextBox();
			this.lblSignoMoneda = new System.Windows.Forms.Label();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.textBoxCantidad = new System.Windows.Forms.TextBox();
			this.groupBoxCotizacion = new System.Windows.Forms.GroupBox();
			this.btnCotizar = new System.Windows.Forms.Button();
			this.lblSignoMoneda2 = new System.Windows.Forms.Label();
			this.lblCotizacionFinal = new System.Windows.Forms.Label();
			this.groupBoxCalidad.SuspendLayout();
			this.groupBoxPrenda.SuspendLayout();
			this.groupBoxStock.SuspendLayout();
			this.groupBoxPrecioYCantidad.SuspendLayout();
			this.groupBoxCotizacion.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNombreTienda
			// 
			this.lblNombreTienda.AutoSize = true;
			this.lblNombreTienda.Location = new System.Drawing.Point(12, 9);
			this.lblNombreTienda.Name = "lblNombreTienda";
			this.lblNombreTienda.Size = new System.Drawing.Size(76, 13);
			this.lblNombreTienda.TabIndex = 0;
			this.lblNombreTienda.Text = "Nombre tienda";
			// 
			// lblDireccionTienda
			// 
			this.lblDireccionTienda.AutoSize = true;
			this.lblDireccionTienda.Location = new System.Drawing.Point(324, 9);
			this.lblDireccionTienda.Name = "lblDireccionTienda";
			this.lblDireccionTienda.Size = new System.Drawing.Size(110, 13);
			this.lblDireccionTienda.TabIndex = 1;
			this.lblDireccionTienda.Text = "Direccion de la tienda";
			// 
			// lblNombreVendedor
			// 
			this.lblNombreVendedor.AutoSize = true;
			this.lblNombreVendedor.Location = new System.Drawing.Point(12, 48);
			this.lblNombreVendedor.Name = "lblNombreVendedor";
			this.lblNombreVendedor.Size = new System.Drawing.Size(141, 13);
			this.lblNombreVendedor.TabIndex = 2;
			this.lblNombreVendedor.Text = "Nombre y Apellido Vendedor";
			// 
			// lblHistorialCotizacion
			// 
			this.lblHistorialCotizacion.AutoSize = true;
			this.lblHistorialCotizacion.Location = new System.Drawing.Point(324, 48);
			this.lblHistorialCotizacion.Name = "lblHistorialCotizacion";
			this.lblHistorialCotizacion.Size = new System.Drawing.Size(107, 13);
			this.lblHistorialCotizacion.TabIndex = 3;
			this.lblHistorialCotizacion.Text = "Historial Cotizaciones";
			this.lblHistorialCotizacion.Click += new System.EventHandler(this.lblHistorialCotizacion_Click);
			// 
			// radioBtnCamisa
			// 
			this.radioBtnCamisa.AutoSize = true;
			this.radioBtnCamisa.Checked = true;
			this.radioBtnCamisa.Location = new System.Drawing.Point(24, 52);
			this.radioBtnCamisa.Name = "radioBtnCamisa";
			this.radioBtnCamisa.Size = new System.Drawing.Size(59, 17);
			this.radioBtnCamisa.TabIndex = 4;
			this.radioBtnCamisa.TabStop = true;
			this.radioBtnCamisa.Text = "Camisa";
			this.radioBtnCamisa.UseVisualStyleBackColor = true;
			this.radioBtnCamisa.CheckedChanged += new System.EventHandler(this.radioBtnCamisa_CheckedChanged);
			// 
			// radioBtnPantalon
			// 
			this.radioBtnPantalon.AutoSize = true;
			this.radioBtnPantalon.Location = new System.Drawing.Point(24, 125);
			this.radioBtnPantalon.Name = "radioBtnPantalon";
			this.radioBtnPantalon.Size = new System.Drawing.Size(67, 17);
			this.radioBtnPantalon.TabIndex = 5;
			this.radioBtnPantalon.TabStop = true;
			this.radioBtnPantalon.Text = "Pantalón";
			this.radioBtnPantalon.UseVisualStyleBackColor = true;
			this.radioBtnPantalon.CheckedChanged += new System.EventHandler(this.radioBtnPantalon_CheckedChanged);
			// 
			// checkBoxMangaCorta
			// 
			this.checkBoxMangaCorta.AutoSize = true;
			this.checkBoxMangaCorta.Location = new System.Drawing.Point(191, 52);
			this.checkBoxMangaCorta.Name = "checkBoxMangaCorta";
			this.checkBoxMangaCorta.Size = new System.Drawing.Size(87, 17);
			this.checkBoxMangaCorta.TabIndex = 6;
			this.checkBoxMangaCorta.Text = "Manga Corta";
			this.checkBoxMangaCorta.UseVisualStyleBackColor = true;
			this.checkBoxMangaCorta.CheckedChanged += new System.EventHandler(this.checkBoxMangaCorta_CheckedChanged);
			// 
			// checkBoxCuelloMao
			// 
			this.checkBoxCuelloMao.AutoSize = true;
			this.checkBoxCuelloMao.Location = new System.Drawing.Point(323, 53);
			this.checkBoxCuelloMao.Name = "checkBoxCuelloMao";
			this.checkBoxCuelloMao.Size = new System.Drawing.Size(79, 17);
			this.checkBoxCuelloMao.TabIndex = 7;
			this.checkBoxCuelloMao.Text = "Cuello Mao";
			this.checkBoxCuelloMao.UseVisualStyleBackColor = true;
			this.checkBoxCuelloMao.CheckedChanged += new System.EventHandler(this.checkBoxCuelloMao_CheckedChanged);
			// 
			// checkBoxChupin
			// 
			this.checkBoxChupin.AutoSize = true;
			this.checkBoxChupin.Location = new System.Drawing.Point(191, 126);
			this.checkBoxChupin.Name = "checkBoxChupin";
			this.checkBoxChupin.Size = new System.Drawing.Size(59, 17);
			this.checkBoxChupin.TabIndex = 8;
			this.checkBoxChupin.Text = "Chupin";
			this.checkBoxChupin.UseVisualStyleBackColor = true;
			this.checkBoxChupin.CheckedChanged += new System.EventHandler(this.checkBoxChupin_CheckedChanged);
			// 
			// labelStock
			// 
			this.labelStock.AutoSize = true;
			this.labelStock.Location = new System.Drawing.Point(6, 16);
			this.labelStock.Name = "labelStock";
			this.labelStock.Size = new System.Drawing.Size(154, 13);
			this.labelStock.TabIndex = 9;
			this.labelStock.Text = "Unidades de stock disponibles:";
			// 
			// lblValorStock
			// 
			this.lblValorStock.AutoSize = true;
			this.lblValorStock.Location = new System.Drawing.Point(166, 16);
			this.lblValorStock.Name = "lblValorStock";
			this.lblValorStock.Size = new System.Drawing.Size(61, 13);
			this.lblValorStock.TabIndex = 10;
			this.lblValorStock.Text = "_________";
			// 
			// radioButtonStandard
			// 
			this.radioButtonStandard.AutoSize = true;
			this.radioButtonStandard.Checked = true;
			this.radioButtonStandard.Location = new System.Drawing.Point(24, 30);
			this.radioButtonStandard.Name = "radioButtonStandard";
			this.radioButtonStandard.Size = new System.Drawing.Size(68, 17);
			this.radioButtonStandard.TabIndex = 12;
			this.radioButtonStandard.TabStop = true;
			this.radioButtonStandard.Text = "Standard";
			this.radioButtonStandard.UseVisualStyleBackColor = true;
			// 
			// radioButtonPremium
			// 
			this.radioButtonPremium.AutoSize = true;
			this.radioButtonPremium.Location = new System.Drawing.Point(113, 30);
			this.radioButtonPremium.Name = "radioButtonPremium";
			this.radioButtonPremium.Size = new System.Drawing.Size(65, 17);
			this.radioButtonPremium.TabIndex = 13;
			this.radioButtonPremium.TabStop = true;
			this.radioButtonPremium.Text = "Premium";
			this.radioButtonPremium.UseVisualStyleBackColor = true;
			// 
			// groupBoxCalidad
			// 
			this.groupBoxCalidad.Controls.Add(this.radioButtonPremium);
			this.groupBoxCalidad.Controls.Add(this.radioButtonStandard);
			this.groupBoxCalidad.Location = new System.Drawing.Point(15, 317);
			this.groupBoxCalidad.Name = "groupBoxCalidad";
			this.groupBoxCalidad.Size = new System.Drawing.Size(200, 69);
			this.groupBoxCalidad.TabIndex = 14;
			this.groupBoxCalidad.TabStop = false;
			this.groupBoxCalidad.Text = "Calidad de Prenda";
			// 
			// groupBoxPrenda
			// 
			this.groupBoxPrenda.Controls.Add(this.label1);
			this.groupBoxPrenda.Controls.Add(this.checkBoxCuelloMao);
			this.groupBoxPrenda.Controls.Add(this.radioBtnCamisa);
			this.groupBoxPrenda.Controls.Add(this.radioBtnPantalon);
			this.groupBoxPrenda.Controls.Add(this.checkBoxMangaCorta);
			this.groupBoxPrenda.Controls.Add(this.checkBoxChupin);
			this.groupBoxPrenda.Location = new System.Drawing.Point(15, 81);
			this.groupBoxPrenda.Name = "groupBoxPrenda";
			this.groupBoxPrenda.Size = new System.Drawing.Size(552, 169);
			this.groupBoxPrenda.TabIndex = 15;
			this.groupBoxPrenda.TabStop = false;
			this.groupBoxPrenda.Text = "Prenda";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(511, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "_________________________________________________________________________________" +
    "___";
			// 
			// groupBoxStock
			// 
			this.groupBoxStock.Controls.Add(this.labelStock);
			this.groupBoxStock.Controls.Add(this.lblValorStock);
			this.groupBoxStock.Location = new System.Drawing.Point(15, 256);
			this.groupBoxStock.Name = "groupBoxStock";
			this.groupBoxStock.Size = new System.Drawing.Size(552, 46);
			this.groupBoxStock.TabIndex = 16;
			this.groupBoxStock.TabStop = false;
			// 
			// groupBoxPrecioYCantidad
			// 
			this.groupBoxPrecioYCantidad.Controls.Add(this.lblCantidad);
			this.groupBoxPrecioYCantidad.Controls.Add(this.textBoxCantidad);
			this.groupBoxPrecioYCantidad.Controls.Add(this.lblSignoMoneda);
			this.groupBoxPrecioYCantidad.Controls.Add(this.textBoxPrecio);
			this.groupBoxPrecioYCantidad.Location = new System.Drawing.Point(234, 317);
			this.groupBoxPrecioYCantidad.Name = "groupBoxPrecioYCantidad";
			this.groupBoxPrecioYCantidad.Size = new System.Drawing.Size(333, 69);
			this.groupBoxPrecioYCantidad.TabIndex = 17;
			this.groupBoxPrecioYCantidad.TabStop = false;
			this.groupBoxPrecioYCantidad.Text = "Precio Unitario y Cantidad ";
			// 
			// textBoxPrecio
			// 
			this.textBoxPrecio.Location = new System.Drawing.Point(31, 29);
			this.textBoxPrecio.Name = "textBoxPrecio";
			this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
			this.textBoxPrecio.TabIndex = 0;
			// 
			// lblSignoMoneda
			// 
			this.lblSignoMoneda.AutoSize = true;
			this.lblSignoMoneda.Location = new System.Drawing.Point(12, 33);
			this.lblSignoMoneda.Name = "lblSignoMoneda";
			this.lblSignoMoneda.Size = new System.Drawing.Size(13, 13);
			this.lblSignoMoneda.TabIndex = 18;
			this.lblSignoMoneda.Text = "$";
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Location = new System.Drawing.Point(153, 32);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(49, 13);
			this.lblCantidad.TabIndex = 20;
			this.lblCantidad.Text = "Cantidad";
			// 
			// textBoxCantidad
			// 
			this.textBoxCantidad.Location = new System.Drawing.Point(208, 29);
			this.textBoxCantidad.Name = "textBoxCantidad";
			this.textBoxCantidad.Size = new System.Drawing.Size(100, 20);
			this.textBoxCantidad.TabIndex = 19;
			// 
			// groupBoxCotizacion
			// 
			this.groupBoxCotizacion.Controls.Add(this.lblCotizacionFinal);
			this.groupBoxCotizacion.Controls.Add(this.lblSignoMoneda2);
			this.groupBoxCotizacion.Controls.Add(this.btnCotizar);
			this.groupBoxCotizacion.Location = new System.Drawing.Point(15, 415);
			this.groupBoxCotizacion.Name = "groupBoxCotizacion";
			this.groupBoxCotizacion.Size = new System.Drawing.Size(552, 100);
			this.groupBoxCotizacion.TabIndex = 18;
			this.groupBoxCotizacion.TabStop = false;
			this.groupBoxCotizacion.Text = "Cotizacion";
			// 
			// btnCotizar
			// 
			this.btnCotizar.Location = new System.Drawing.Point(9, 29);
			this.btnCotizar.Name = "btnCotizar";
			this.btnCotizar.Size = new System.Drawing.Size(156, 51);
			this.btnCotizar.TabIndex = 0;
			this.btnCotizar.Text = "Cotizar";
			this.btnCotizar.UseVisualStyleBackColor = true;
			this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
			// 
			// lblSignoMoneda2
			// 
			this.lblSignoMoneda2.AutoSize = true;
			this.lblSignoMoneda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSignoMoneda2.Location = new System.Drawing.Point(180, 40);
			this.lblSignoMoneda2.Name = "lblSignoMoneda2";
			this.lblSignoMoneda2.Size = new System.Drawing.Size(20, 24);
			this.lblSignoMoneda2.TabIndex = 21;
			this.lblSignoMoneda2.Text = "$";
			// 
			// lblCotizacionFinal
			// 
			this.lblCotizacionFinal.AutoSize = true;
			this.lblCotizacionFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCotizacionFinal.Location = new System.Drawing.Point(206, 40);
			this.lblCotizacionFinal.Name = "lblCotizacionFinal";
			this.lblCotizacionFinal.Size = new System.Drawing.Size(120, 24);
			this.lblCotizacionFinal.TabIndex = 22;
			this.lblCotizacionFinal.Text = "___________";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 583);
			this.Controls.Add(this.groupBoxCotizacion);
			this.Controls.Add(this.groupBoxPrecioYCantidad);
			this.Controls.Add(this.groupBoxStock);
			this.Controls.Add(this.groupBoxPrenda);
			this.Controls.Add(this.groupBoxCalidad);
			this.Controls.Add(this.lblHistorialCotizacion);
			this.Controls.Add(this.lblNombreVendedor);
			this.Controls.Add(this.lblDireccionTienda);
			this.Controls.Add(this.lblNombreTienda);
			this.Name = "Form1";
			this.Text = "Cotizador";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBoxCalidad.ResumeLayout(false);
			this.groupBoxCalidad.PerformLayout();
			this.groupBoxPrenda.ResumeLayout(false);
			this.groupBoxPrenda.PerformLayout();
			this.groupBoxStock.ResumeLayout(false);
			this.groupBoxStock.PerformLayout();
			this.groupBoxPrecioYCantidad.ResumeLayout(false);
			this.groupBoxPrecioYCantidad.PerformLayout();
			this.groupBoxCotizacion.ResumeLayout(false);
			this.groupBoxCotizacion.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNombreTienda;
		private System.Windows.Forms.Label lblDireccionTienda;
		private System.Windows.Forms.Label lblNombreVendedor;
		private System.Windows.Forms.Label lblHistorialCotizacion;
		private System.Windows.Forms.RadioButton radioBtnCamisa;
		private System.Windows.Forms.RadioButton radioBtnPantalon;
		private System.Windows.Forms.CheckBox checkBoxMangaCorta;
		private System.Windows.Forms.CheckBox checkBoxCuelloMao;
		private System.Windows.Forms.CheckBox checkBoxChupin;
		private System.Windows.Forms.Label labelStock;
		private System.Windows.Forms.Label lblValorStock;
		private System.Windows.Forms.RadioButton radioButtonStandard;
		private System.Windows.Forms.RadioButton radioButtonPremium;
		private System.Windows.Forms.GroupBox groupBoxCalidad;
		private System.Windows.Forms.GroupBox groupBoxPrenda;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBoxStock;
		private System.Windows.Forms.GroupBox groupBoxPrecioYCantidad;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.TextBox textBoxCantidad;
		private System.Windows.Forms.Label lblSignoMoneda;
		private System.Windows.Forms.TextBox textBoxPrecio;
		private System.Windows.Forms.GroupBox groupBoxCotizacion;
		private System.Windows.Forms.Label lblCotizacionFinal;
		private System.Windows.Forms.Label lblSignoMoneda2;
		private System.Windows.Forms.Button btnCotizar;
	}
}

