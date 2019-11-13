using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDiseno; //Reportes y ayuda
using CapaDiseno; // Seguridad
using Finanzas;
using Recursos_Humanos;

namespace HSC
{
	public partial class MDIParent1 : Form
	{
		private int childFormNumber = 0;

		public MDIParent1()
		{
			InitializeComponent();
		}

		private void ShowNewForm(object sender, EventArgs e)
		{
			Form childForm = new Form();
			childForm.MdiParent = this;
			childForm.Text = "Ventana " + childFormNumber++;
			childForm.Show();
		}

		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = openFileDialog.FileName;
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = saveFileDialog.FileName;
			}
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form childForm in MdiChildren)
			{
				childForm.Close();
			}
		}

		private void MDIParent1_Load(object sender, EventArgs e)
		{

		}

		private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Reportes ReportesForm = new Reportes();
			ReportesForm.MdiParent = this;
			ReportesForm.Show();
		}

		private void AyudasToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Ayudas AyudasForm = new Ayudas();
			AyudasForm.MdiParent = this;
			AyudasForm.Show();
		}

		private void AyudasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MDI_Seguridad seguridad = new MDI_Seguridad("MiUsuario");
			seguridad.ShowDialog();
		}

		private void FinanzasToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void ContabilidadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MDI_Contabilidad conta = new MDI_Contabilidad();
			conta.Show();
		}

		private void BancosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MDI_Bancos bancos = new MDI_Bancos();
			bancos.Show();
		}

		private void RRHHToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MDI_RRHH rh = new MDI_RRHH();
			rh.Show();
		}
	}
}
