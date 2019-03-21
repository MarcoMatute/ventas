using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class FacturaBL
    {
        public BindingList<Factura> ListadeFacturas { get; set; }
        public int NumeroFactura { get; set; }

        public FacturaBL()
        {
            ListadeFacturas = new BindingList<Factura>();
            NumeroFactura = 1;
        }

        public void NuevaFactura()
        {
            var nuevaFactura = new Factura();
            nuevaFactura.Id = NumeroFactura;

            ListadeFacturas.Add(nuevaFactura);
            NumeroFactura += 1;
        }
    }
}
