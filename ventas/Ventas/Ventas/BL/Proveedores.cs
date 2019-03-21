using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ProveedoresBL
    {
        public BindingList<Proveedores> ListadeProveedores { get; set; }

        public ProveedoresBL()
        {
            ListadeProveedores = new BindingList<Proveedores>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "San Pedro Sula");
            var ciudad2 = new Ciudad(2, "Tegucigalpa");

            var proveedor1 = new Proveedores(1, "Compu Master","Carlos Perez", "99558877", "SPS", ciudad1);
            var proveedor2 = new Proveedores(2, "HP","Mario Cruz", "88557744", "Tegus", ciudad2);

            ListadeProveedores.Add(proveedor1);
            ListadeProveedores.Add(proveedor2);
        }
    }
}
