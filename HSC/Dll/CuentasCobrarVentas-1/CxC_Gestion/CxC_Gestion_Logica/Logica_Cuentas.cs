using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CxC_Gestion_Datos;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;

namespace CxC_Gestion_Logica
{
    public class Logica_Cuentas
    {
        Sentencias_Cuentas SentenciasCuentas = new Sentencias_Cuentas();
        public void Periodo(ComboBox cboperiodo)
        {
            OdbcDataAdapter odbcPeriodo = SentenciasCuentas.ObtenerPer();
            DataTable dtPeriodo = new DataTable();
            odbcPeriodo.Fill(dtPeriodo);

            if (dtPeriodo.Rows.Count > 0)
            {
                for (int i = 0; i < dtPeriodo.Rows.Count; i++)
                {
                    DataRow rs = dtPeriodo.Rows[i];
                    string sPer = rs["Periodo"].ToString();
                    cboperiodo.Items.Add(sPer);
                }
            }
        }

        public void ConsultarCliente(ComboBox cboClientes)
        {
            OdbcDataAdapter CodCliente = SentenciasCuentas.ConsultarClientes();
            DataTable dtCodCliente = new DataTable();
            CodCliente.Fill(dtCodCliente);
            if (dtCodCliente.Rows.Count > 0)
            {
                for (int i = 0; i < dtCodCliente.Rows.Count; i++)
                {
                    DataRow rows = dtCodCliente.Rows[i];
                    string sCodCliente = rows["KidCliente"].ToString();
                    cboClientes.Items.Add(sCodCliente);
                }
            }
        }

        public void idPeriodo(TextBox txt_per, int Periodo)
        {
            OdbcDataAdapter idPer = SentenciasCuentas.idPeriodo(Periodo);
            DataTable dtId = new DataTable();
            idPer.Fill(dtId);

            for (int i = 0; i < dtId.Rows.Count; i++)
            {
                DataRow rs = dtId.Rows[i];
                string sCodPer = rs["KidPeriodo"].ToString();
                txt_per.Text = sCodPer;
            }

        }

        public void fecha(TextBox txt_fecha, int CodigoCliente, int Periodo)
        {
            OdbcDataAdapter idPer = SentenciasCuentas.fecha(Periodo,CodigoCliente);
            DataTable dtId = new DataTable();
            idPer.Fill(dtId);

            for (int i = 0; i < dtId.Rows.Count; i++)
            {
                DataRow rs = dtId.Rows[i];
                string sCodPer = rs["fecha"].ToString();
                txt_fecha.Text = sCodPer;
            }

        }

        public DataTable cuentasporcobrar(int codPeriodo,int codCliente)
        {
            OdbcDataAdapter datos = SentenciasCuentas.CuentasporCobrar(codPeriodo, codCliente);
            DataTable dtDatos = new DataTable();
            datos.Fill(dtDatos);
            return dtDatos;
        }

    }
}
