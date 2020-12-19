using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotizador
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());


			//Generar prendas
			Camisa camisaMangaCortaNormal = new Camisa(300, true, false);//Camisa manga corta normal con stock de 300
			Camisa camisaMangaCortaMao = new Camisa(200, true, true);//Camisa manga corta cuello mao con stock de 200
			Camisa camisaMangaLargaNormal = new Camisa(350, false, false);//Camisa manga larga normal con stock de 350
			Camisa camisaMangaLargaMao = new Camisa(150, false, true);//Camisa manga larga cuello mao con stock de 150

			Pantalon pantalonChupin = new Pantalon(1500, true);//Pantalon Chupin con stock de 1500
			Pantalon pantalonNormal = new Pantalon(500);//Pantalon Normal con stock de 500

		}
	}
}
