using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BL;
using Ventas.Modelos;

namespace Ventas
{
    public partial class Form5 : Form
    {
        ComprasBL _comprasBL;
        public Form5()
        {
            InitializeComponent();
        }
        public void cargarDatos(ComprasBL comprasBL, ProveedoresBL proveedoresBL, ProductosBL productosBL)
        {
            _comprasBL = comprasBL;

            listadeComprasBindingSource.DataSource = comprasBL.ListadeCompras;
            listadeProveedoresBindingSource.DataSource = proveedoresBL.ListadeProveedores;
           // listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;
        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Compra)listadeComprasBindingSource.Current;
            factura.CalcularTotalCompra();

            listadeComprasBindingSource.ResetBindings(false);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //_comprasBL.NuevaCompra();
            listadeComprasBindingSource.MoveLast();
        }

        public void cargarDatos(ComprasBL comprasBL, CategoriasBL categoriasBL)
        {
            listadeComprasBindingSource.DataSource = comprasBL.ListadeCompras;
            //listadeCategoriasBindingSource.DataSource = categoriasBL.ListadeCategorias;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            var archivo = openFileDialog1.FileName;

            if (archivo != "")
            {
                var fileInfo = new FileInfo(archivo);
                var fileStream = fileInfo.OpenRead();

                pictureBox1.Image = Image.FromStream(fileStream);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
