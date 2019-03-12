using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ClientesBL
    {
        public BindingList<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new BindingList<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Comayagua");
            var ciudad2 = new Ciudad(2, "Puerto Cortes");

            var cliente1 = new Cliente(1, "Jose Caceres", "32987634", "Cmyg", ciudad1);
            var cliente2 = new Cliente(2, "Juan Perez", "92384432", "Pto Cortes", ciudad2);

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
        }
    }
}
