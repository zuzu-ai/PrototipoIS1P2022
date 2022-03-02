using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
	public partial class Producto : Form
	{
		public Producto()
		{
			InitializeComponent();
			//TextBox[] alias = { txtID, txtCodigoMarca, txtNombre, txtFecha, txtDescripcion, txtStock, txtPrecio, txtEstatus};
			TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
			navegador1.ObtenerCamposdeTabla(alias, "productos", "sic");
			navegador1.MetodoSalirVista(this);
			// navegador1.funLlenarComboControl(cbxCodMarca, "marcaP", "idMarca", "nombre", "estatus");

			//inicio de elementos para dar de baja
			navegador1.campoEstado = "estatus_producto";
			//fin de elementos para dar de baja

			/* Inicio ID Aplicacion usada para reportes y ayudas */
		
			/* Inicio ID Aplicacion usada para reportes y ayudas */

			//inicio de elementos para ejecutar la ayuda

			//fin de elementos para ejecutar la ayuda


			// Inicio datos para ejecurar reportes
			// Final datos para ejecutar reportes

			navegador1.ObtenerNombreDGV(this.dtg);
			navegador1.LlenarTabla();
			navegador1.ObtenerReferenciaFormActual(this);
			//String cadena = txtprueba.Text;
			//navegador1.pruebaMensaje(cadena);
		}

		private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.CambioEstadoTextbox(estatus, rbnEstatusamodulo, "1");
		}

		private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.CambioEstadoTextbox(estatus, rbnEstatusimodulo, "1");
		}

		private void estatus_TextChanged(object sender, EventArgs e)
		{
			navegador1.ActivaRadiobtn(rbnEstatusamodulo, rbnEstatusimodulo, estatus);
		}
	}
}
