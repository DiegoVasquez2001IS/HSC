using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CxC_Gestion_Logica;
namespace CxC_Gestion
{
    public partial class CxC_gestion : UserControl
    {
        Logica_Cuentas CapaLogica = new Logica_Cuentas();
        TextBox txt_periodo = new TextBox();
        TextBox txt_fecha = new TextBox();
        public CxC_gestion()
        {
            InitializeComponent();
            CapaLogica.ConsultarCliente(cbo_clientes);
            CapaLogica.Periodo(cbo_Periodo);
            
        }

        private void tbc_ListarMovimientos_Click(object sender, EventArgs e)
        {

        }

        private void cbo_Periodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapaLogica.idPeriodo(txt_periodo, Convert.ToInt32(cbo_Periodo.Text));
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cbo_clientes.Text == "" | cbo_Periodo.Text == "")
            {
                MessageBox.Show("Debe seleccionar datos");
            }
            else
            {
                int codigoCliente = Convert.ToInt32(cbo_clientes.Text);
                int Periodo = Convert.ToInt32(txt_periodo.Text);

                CapaLogica.fecha(txt_fecha, codigoCliente, Periodo);
                string fecha = txt_fecha.Text;
                DateTime fecham = new DateTime();
                fecham = Convert.ToDateTime(fecha);
                MessageBox.Show(Convert.ToString(fecham));

                DataTable dtDatosCuenta = CapaLogica.cuentasporcobrar(Periodo, codigoCliente);
                dgv_Cuentas.DataSource = dtDatosCuenta;
            }
        }

        private void cbo_Periodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbo_clientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
