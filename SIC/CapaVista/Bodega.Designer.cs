
namespace CapaVista
{
	partial class Bodega
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
			this.navegador1 = new DLL.nav.navegador();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.estatus = new System.Windows.Forms.TextBox();
			this.dtg = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
			this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.navegador1.Location = new System.Drawing.Point(1, 2);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1189, 87);
			this.navegador1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Codigo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 171);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Estado";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(67, 141);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(160, 20);
			this.textBox1.TabIndex = 7;
			this.textBox1.Tag = "codigo_bodega";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(67, 168);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(160, 20);
			this.textBox2.TabIndex = 8;
			this.textBox2.Tag = "nombre_bodega";
			// 
			// estatus
			// 
			this.estatus.Location = new System.Drawing.Point(95, 243);
			this.estatus.Name = "estatus";
			this.estatus.Size = new System.Drawing.Size(88, 20);
			this.estatus.TabIndex = 9;
			this.estatus.Tag = "estatus_bodega";
			this.estatus.TextChanged += new System.EventHandler(this.estatus_TextChanged);
			// 
			// dtg
			// 
			this.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtg.Location = new System.Drawing.Point(284, 95);
			this.dtg.Name = "dtg";
			this.dtg.Size = new System.Drawing.Size(634, 183);
			this.dtg.TabIndex = 51;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbnEstatusamodulo);
			this.panel1.Controls.Add(this.rbnEstatusimodulo);
			this.panel1.Location = new System.Drawing.Point(67, 194);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 30);
			this.panel1.TabIndex = 52;
			// 
			// rbnEstatusamodulo
			// 
			this.rbnEstatusamodulo.AutoSize = true;
			this.rbnEstatusamodulo.Location = new System.Drawing.Point(12, 7);
			this.rbnEstatusamodulo.Name = "rbnEstatusamodulo";
			this.rbnEstatusamodulo.Size = new System.Drawing.Size(55, 17);
			this.rbnEstatusamodulo.TabIndex = 8;
			this.rbnEstatusamodulo.TabStop = true;
			this.rbnEstatusamodulo.Text = "Activo";
			this.rbnEstatusamodulo.UseVisualStyleBackColor = true;
			this.rbnEstatusamodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusamodulo_CheckedChanged);
			// 
			// rbnEstatusimodulo
			// 
			this.rbnEstatusimodulo.AutoSize = true;
			this.rbnEstatusimodulo.Location = new System.Drawing.Point(134, 7);
			this.rbnEstatusimodulo.Name = "rbnEstatusimodulo";
			this.rbnEstatusimodulo.Size = new System.Drawing.Size(63, 17);
			this.rbnEstatusimodulo.TabIndex = 9;
			this.rbnEstatusimodulo.TabStop = true;
			this.rbnEstatusimodulo.Text = "Inactivo";
			this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
			this.rbnEstatusimodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
			// 
			// Bodega
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1183, 285);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dtg);
			this.Controls.Add(this.estatus);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.navegador1);
			this.Name = "Bodega";
			this.Text = "Bodega";
			((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DLL.nav.navegador navegador1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox estatus;
		private System.Windows.Forms.DataGridView dtg;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnEstatusamodulo;
		private System.Windows.Forms.RadioButton rbnEstatusimodulo;
	}
}