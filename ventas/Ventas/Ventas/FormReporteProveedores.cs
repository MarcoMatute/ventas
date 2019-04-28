using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BL;

namespace Ventas
{
    public partial class FormReporteProveedores : Form
    {
        public FormReporteProveedores()
        {
            InitializeComponent();
        }
        public void CargarDatos(ProveedoresBL proveedoresBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from x in proveedoresBL.ListadeProveedores
                select new
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Contacto = x.Contacto,
                    Telefono=x.Telefono
                };

            var reporte = new ReportedeProveedores();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
