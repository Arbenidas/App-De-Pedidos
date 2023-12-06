using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppPedidos
{
    public partial class Formulario : Form
    {
        
        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            //refresca los datos en el reportviewer luego de cargar los
            this.reportViewer1.RefreshReport();
            cargarDatos();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            

        }

        private void cargarDatos()
        {
            List<Producto> listProductos = new List<Producto>();
            listProductos = ProductoLogica.Listar();
            
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppPedidos.Report1.rdlc";
            
            ReportDataSource reportDataSource = new ReportDataSource("Productos", listProductos);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
