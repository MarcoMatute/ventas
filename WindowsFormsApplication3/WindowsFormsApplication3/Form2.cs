using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void cargarDatos(ClientesBL clientesBL, CiudadBL ciudadesBL)
        
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
            listadeCiudadesBindingSource.DataSource = ciudadesBL.ListadeCiudades;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void clientesBLBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
