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
	public partial class CotizacionesForm : Form
	{
		public CotizacionesForm()
		{
			InitializeComponent();
		}

		public void  SetTextBox(string message) {
			textBoxCotizaciones.Text = message;
		}

	}
}
