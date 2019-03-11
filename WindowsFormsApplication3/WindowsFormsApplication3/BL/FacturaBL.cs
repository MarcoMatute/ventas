using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.modelos;

namespace WindowsFormsApplication3.BL
{
    public class FacturaBL
    {
        public BindingList <Factura> ListadeFacturas { get; set; }

        public FacturaBL()
        {
            ListadeFacturas = new System.ComponentModel.BindingList<Factura>();

        }
    }
}
