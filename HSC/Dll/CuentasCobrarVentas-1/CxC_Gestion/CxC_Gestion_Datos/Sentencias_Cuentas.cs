using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;

namespace CxC_Gestion_Datos
{

    
    public class Sentencias_Cuentas
    {
        public OdbcDataAdapter ConsultarClientes()
        {
            conexion conn = new conexion();
            OdbcConnection conectar = conn.Conectar();
            string sConsultarCliente = "SELECT KidCliente From tbl_clientes WHERE estado = 1 ";
            OdbcDataAdapter odbcConsultarCliente = new OdbcDataAdapter(sConsultarCliente, conectar);
            return odbcConsultarCliente;
        }
        public OdbcDataAdapter ObtenerPer()
        {
            conexion con = new conexion();
            con.Conectar();
            string sPeriodo = "SELECT Periodo FROM tbl_periodo WHERE estado = 1 ";
            OdbcDataAdapter odbcConsultarPer = new OdbcDataAdapter(sPeriodo, con.Conectar());
            return odbcConsultarPer;
        }
        public OdbcDataAdapter idPeriodo(int periodo)
        {
            conexion con = new conexion();
            con.Conectar();
            string sPeriodo = "SELECT KidPeriodo FROM tbl_periodo WHERE Periodo = " + periodo;
            OdbcDataAdapter idPeriodo = new OdbcDataAdapter(sPeriodo, con.Conectar());
            return idPeriodo;
        }

        public OdbcDataAdapter fecha(int codPeriodo, int codCliente)
        {
            conexion con = new conexion();
            con.Conectar();
            string sPeriodo = "Select fecha from tbl_encabezadocomprobante where periodo ="+codPeriodo+" and KidCliente = "+codCliente ;
            OdbcDataAdapter idPeriodo = new OdbcDataAdapter(sPeriodo, con.Conectar());
            return idPeriodo;
        }
        public OdbcDataAdapter CuentasporCobrar(int codPeriodo,int codCliente)
        {
            conexion con = new conexion();
            con.Conectar();
           

           string comand = " select tbl_encabezadocomprobante.KidEncabezadoComprobante as No_Comp, tbl_tipomovimiento.NombreMovimiento as Nombre, tbl_encabezadocomprobante.KidFacturaEncabezado as FacturaReferente, " +
                "tbl_encabezadocomprobante.fecha as FechaEmision, tbl_encabezadocomprobante.fechaVencimiento as FechaFin, " +
                "tbl_detallecomprobante.ValorComprobante from tbl_encabezadocomprobante INNER JOIN tbl_tipomovimiento on " +
                "tbl_encabezadocomprobante.KidtiposComprobantes = tbl_tipomovimiento.KidtipoMovimiento " +
                "INNER JOIN tbl_detallecomprobante on tbl_detallecomprobante.kidCodigoEncabezado = tbl_encabezadocomprobante.KidEncabezadoComprobante " +
                " and tbl_encabezadocomprobante.Periodo = " + codPeriodo + " and tbl_encabezadocomprobante.KidCliente = " +codCliente;


            OdbcDataAdapter adcuenta = new OdbcDataAdapter(comand, con.Conectar());
            return adcuenta;

            /*

            SELECT sum(tbl_detallecomprobante.ValorComprobante) as Haber from tbl_detallecomprobante where tbl_detallecomprobante.Naturaleza = 'suma' 

            SELECT sum(tbl_detallecomprobante.ValorComprobante) as Haber from tbl_detallecomprobante where tbl_detallecomprobante.Naturaleza = 'resta' 
             
             */
        }



    }
}
