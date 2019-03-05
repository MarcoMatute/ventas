using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.BL;

namespace WindowsFormsApplication3
{
    public partial class Menu : Form
    {
        ProductosBL _productosBL;
        CategoriasBL _categoriasBL;
        ClientesBL _clientesBL;
        CiudadBL _ciudadBL;

        public Menu()
        {

            InitializeComponent();
             _productosBL = new ProductosBL();
            _categoriasBL = new CategoriasBL();
            _clientesBL = new ClientesBL();
            _ciudadBL = new CiudadBL();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproductos = new Form1();
            formproductos.MdiParent = this;

            formproductos.cargarDatos(_productosBL, _categoriasBL);
            formproductos.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new Form2();
            formClientes.MdiParent = this;
            formClientes.cargarDatos(_clientesBL, _ciudadBL);

            formClientes.Show();
        }
    }
}
