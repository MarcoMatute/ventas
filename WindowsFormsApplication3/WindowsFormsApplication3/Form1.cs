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
    public partial class Form1 : Form
    {
        private object ProductosBL;

        public Form1()
        {
            InitializeComponent(); 

            var ProductosBL = new ProductosBL();
            listadeProductosBindingSource1.DataSource = ProductosBL.ListadeProductos;

            var CategoriasBL = new CategoriasBL();
            listadeCategoriasBindingSource.DataSource = CategoriasBL.ListadeCategorias;
        }

       
    }
}
