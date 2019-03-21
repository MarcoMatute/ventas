using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ComprasBL
    {
        public BindingList<Compra> ListadeCompras { get; set; }
        public int NumeroCompras { get; set; }

        public ComprasBL()
        {
            ListadeCompras = new BindingList<Compra>();
            NumeroCompras = 1;
        }

        public void NuevaCompras()
        {
            var nuevaCompras = new Compra();
            nuevaCompras.Id = NumeroCompras;

            ListadeCompras.Add(nuevaCompras);
            NumeroCompras += 1;
        }
    }
}
