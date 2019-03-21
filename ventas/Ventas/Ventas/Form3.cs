﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BL;
using Ventas.Modelos;

namespace Ventas
{
    public partial class Form3 : Form
    {
        FacturaBL _facturasBL;
        public Form3()
        {
            InitializeComponent();
        }

        public void cargarDatos(FacturaBL facturasBL, ClientesBL clientesBL, ProductosBL productosBL)
        {
            _facturasBL = facturasBL;

            listadeFacturasBindingSource.DataSource = facturasBL.ListadeFacturas;
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
            listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;
        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listadeFacturasBindingSource.Current;
            factura.CalcularTotalFactura();

            listadeFacturasBindingSource.ResetBindings(false);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturasBL.NuevaFactura();
            listadeFacturasBindingSource.MoveLast();
        }
    }
}
