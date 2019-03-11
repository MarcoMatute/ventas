using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3.modelos
{
   public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha  { get; set; }
        public int ClienteId  { get; set; }
        public Clientes Clientes {get; set; }
        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total    { get; set; }
        public bool Activo { get; set; }

        public BindingList<FacturaDetalle> FacturaDetalles { get; set; }

        public Factura()
        {
            Fecha = DateTime.Now;
            Activo = true;
            FacturaDetalles = new BindingList<FacturaDetalle>(); 
        }
        public class FacturaDetalle
        {
            public int Id { get; set; }
            public int ProductosId { get; set; }
            public Producto Producto { get; set; }

            public int Cantidad { get; set; }
            public double Precio { get; set; }
            public double Total { get; set; }

            public FacturaDetalle()
            {
                Cantidad = 1;
            }
        }
    }
}
