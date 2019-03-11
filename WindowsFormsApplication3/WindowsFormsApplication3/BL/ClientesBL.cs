using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.modelos;

namespace WindowsFormsApplication3.BL
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

            var cliente1 = new Cliente(1, "Jose Caceres", "99213243", "Comayagua", ciudad1);
            var cliente2 = new Cliente(2, "Juan Perez", "92345676", "Puert Cortes", ciudad2);

           ListadeClientes.Add(cliente1);
           ListadeClientes.Add(cliente2);
        }
   
    }

}
