using Clientesproy.BL;
using Clientesproy.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientesproy.BL
{
    public class ClienteBL
    {
        public List<Cliente> ListaCliente { get; set; }

        public ClienteBL()
        {
            ListaCliente = new List<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad("San Pedro Sula");
            var ciudad2 = new Ciudad("Tegucigalpa");

            var cliente1 = new Cliente(1, "Juan Perez");
            var cliente2 = new Cliente(2, "Pedro Lopez");

            ListaCliente.Add(cliente1);
            ListaCliente.Add(cliente2);

        }
    }
}
