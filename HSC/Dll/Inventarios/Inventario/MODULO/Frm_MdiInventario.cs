using System;
using System.Windows.Forms;
using CapaDatos;
using CapaLogica;
using CapaDiseno;
using CapaDisenoInventario;

namespace MODULO
{
    public partial class Frm_MdiInventario : Form
    {
        private String usuario = "admin";
        private String aplicacion = "1";
        public Frm_MdiInventario()
        {
            InitializeComponent();
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bodega frm_Bodega = new Frm_Bodega(usuario, aplicacion);
            frm_Bodega.StartPosition = FormStartPosition.CenterScreen;
            frm_Bodega.MdiParent = this;
            frm_Bodega.Show();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sucursal frm_Sucursal = new Frm_Sucursal(usuario, aplicacion);
            frm_Sucursal.StartPosition = FormStartPosition.CenterScreen;
            frm_Sucursal.MdiParent = this;
            frm_Sucursal.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Stock frm_Stock = new Frm_Stock(usuario, aplicacion);
            frm_Stock.StartPosition = FormStartPosition.CenterScreen;
            frm_Stock.MdiParent = this;
            frm_Stock.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Inventario frm_ProductoBodega = new Frm_Inventario(usuario, aplicacion);
            frm_ProductoBodega.StartPosition = FormStartPosition.CenterScreen;
            frm_ProductoBodega.MdiParent = this;
            frm_ProductoBodega.Show();
        }
        
        private void tipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TipoProducto tipoProducto = new Frm_TipoProducto(usuario, aplicacion);
            tipoProducto.StartPosition = FormStartPosition.CenterScreen;
            tipoProducto.MdiParent = this;
            tipoProducto.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Producto frm_Cliente = new Frm_Producto(usuario, aplicacion);
            frm_Cliente.StartPosition = FormStartPosition.CenterScreen;
            frm_Cliente.MdiParent = this;
            frm_Cliente.Show();
        }
        
        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Marca frm_Marca = new Frm_Marca(usuario, aplicacion);
            frm_Marca.StartPosition = FormStartPosition.CenterScreen;
            frm_Marca.MdiParent = this;
            frm_Marca.Show();
        }

        private void productoMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProdMarca frm_ProdMarca = new Frm_ProdMarca(usuario, aplicacion);
            frm_ProdMarca.StartPosition = FormStartPosition.CenterScreen;
            frm_ProdMarca.MdiParent = this;
            frm_ProdMarca.Show();
        }

        private void ubicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Ubicacion frm_Ubicacion = new Frm_Ubicacion(usuario, aplicacion);
            frm_Ubicacion.StartPosition = FormStartPosition.CenterScreen;
            frm_Ubicacion.MdiParent = this;
            frm_Ubicacion.Show();
        }

        private void Frm_MdiInventario_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
            usuario = login.obtenerNombreUsuario();
        }

        private void polizaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trasladoDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saldosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void muestreoAuditorioaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
