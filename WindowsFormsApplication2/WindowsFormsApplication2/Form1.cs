using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente1 = new Cliente();
            cliente1.id = 2;
            cliente1.nombre = "Jose";
            cliente1.telefono = 97321234;
            cliente1.direccion = "col. Del Valle";
                var cliente2 = new Cliente();
            cliente2.id = 3;
            cliente2.nombre = "Carlos";
            cliente2.telefono = 97321234;
            cliente2.direccion = "col. Smith";
                var cliente3 = new Cliente();
            cliente3.id = 4;
            cliente3.nombre = "Pedro";
            cliente3.telefono = 97321234;
            cliente3.direccion = "col. Bermejo";

            var ciudad = new ciudad();
            ciudad.id = 1;
            ciudad.descripcion = "San Pedro Sula";

            ciudad.Cliente = cliente1;

            var listadeCliente = new List<Cliente>();
            listadeCliente.Add(cliente1);
            listadeCliente.Add(cliente2);
            listadeCliente.Add(cliente3);

            foreach (var c in listadeCliente)
            {
                MessageBox.Show(c.nombre + " " + c.direccion);
            }
            
        }
    }
}
