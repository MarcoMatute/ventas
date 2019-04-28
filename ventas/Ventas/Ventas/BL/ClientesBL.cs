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
            var ciudad1 = new Ciudad(1, "San Pedro Sula");
            var ciudad2 = new Ciudad(2, "Tegucigalpa");
            var ciudad3 = new Ciudad(3, "Comayagua");
            var ciudad4 = new Ciudad(4, "Puerto Cortes");
            var ciudad5 = new Ciudad(5, "Villanueva");
            var ciudad6 = new Ciudad(6, "Choloma");

            var cliente1 = new Cliente(1, "Juan Perez", "99558877", "SPS", ciudad1);
            var cliente2 = new Cliente(2, "Maria Martinez", "88557744", "Tegus", ciudad2);
            var cliente3 = new Cliente(3, "Marco Lopez", "88347546", "Comayagua", ciudad3);
            var cliente4 = new Cliente(4, "Pedro Gutierrez", "99553734", "Puerto Cortes", ciudad4);
            var cliente5 = new Cliente(5, "Daniel Fernandez", "33553745", "Villanueva", ciudad5);
            var cliente6 = new Cliente(6, "Alex Cruz", "98554732", "SPS", ciudad1);
            var cliente7 = new Cliente(7, "Jose Lopez", "98554732", "Choloma", ciudad6);
            var cliente8 = new Cliente(8, "Carlos Matute", "98554732", "Puerto Cortes", ciudad4);
            var cliente9 = new Cliente(9, "Karla Reyes", "98564532", "Tegus", ciudad2);
            var cliente10 = new Cliente(10, "Adan Calix", "96554734", "SPS", ciudad1);


            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
            ListadeClientes.Add(cliente4);
            ListadeClientes.Add(cliente5);
            ListadeClientes.Add(cliente6);
           
        }
    }
}
