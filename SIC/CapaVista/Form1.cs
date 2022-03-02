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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bodega form3 = new Bodega();
			form3.MdiParent = this;
			form3.Show();
		}

		private void lineasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Lineas form3 = new Lineas();
			form3.MdiParent = this;
			form3.Show();
		}

		private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Marca form3 = new Marca();
			form3.MdiParent = this;
			form3.Show();
		}

		private void productosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Producto form3 = new Producto();
			form3.MdiParent = this;
			form3.Show();
		}
	}
}
