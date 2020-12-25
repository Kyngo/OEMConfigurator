using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace OEMConfigurator
{
	static class Program
	{
		public static Boolean IsAdministrator()
		{
			var identity = WindowsIdentity.GetCurrent();
			var principal = new WindowsPrincipal(identity);
			return principal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (IsAdministrator() == false)
			{
                MessageBox.Show("This application requires to be run as administrator!", "Whoops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
			else
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
			}
		}
	}
}
