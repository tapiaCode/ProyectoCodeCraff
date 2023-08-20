using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using ProyectoCodeCraft.RN;

namespace ProyectoCodeCraff.Reportes
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReporteEmpleado_Load(object sender, EventArgs e)
        {
            MostrarReporte(RNUtilitarios.Utilitarios.TipodeReporte);
            this.reportViewer1.RefreshReport();
        }
        private void MostrarReporte(Int32 TipodeReporte)
        {
            ReportDataSource RpDataSource = new ReportDataSource();
            switch (TipodeReporte)
            {
                case 1: //listado de empleado
                    RNEmpleado ObjRnEmpleado = new RNEmpleado();
                    RpDataSource.Name = "DataSet1";
                    RpDataSource.Value = ObjRnEmpleado.TrearEmpleado(RNUtilitarios.Utilitarios.id);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(RpDataSource);
                    this.reportViewer1.LocalReport.ReportPath = @"C:\dev\grupoMaster\ProyectoCodeCraff\ProyectoCodeCraff\RptEmpleado.rdlc";
                    this.reportViewer1.RefreshReport();
                    
                    break;
                case 2: //listado de Cliente Natural
                    RNNatural ObjRnNatural = new RNNatural();
                    RpDataSource.Name = "DataSet1";
                    RpDataSource.Value = ObjRnNatural.TraerClienteNatural(RNUtilitarios.Utilitarios.id);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(RpDataSource);
                    this.reportViewer1.LocalReport.ReportPath = @"C:\dev\grupoMaster\ProyectoCodeCraff\ProyectoCodeCraff\RptCliente.rdlc";
                    this.reportViewer1.RefreshReport();

                    break;
                case 3: //listado de empleado
                    RNUsuario ObjRnUsuario = new RNUsuario();
                    RpDataSource.Name = "DataSet1";
                    RpDataSource.Value = ObjRnUsuario.TraerUsuarios(RNUtilitarios.Utilitarios.id);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(RpDataSource);
                    this.reportViewer1.LocalReport.ReportPath = @"C:\dev\grupoMaster\ProyectoCodeCraff\ProyectoCodeCraff\RptUsuarios.rdlc";
                    this.reportViewer1.RefreshReport();

                    break;

            }

        }
    }

}