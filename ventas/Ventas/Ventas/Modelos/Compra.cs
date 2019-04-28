using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.BL;

namespace Ventas.Modelos
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int ProveedorId { get; set; }
        //public Proveedor Proveedor { get; set; }

        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public byte [] Foto { get; set; }

        public bool Activo { get; set; }

        public BindingList<CompraDetalle> CompraDetalle { get; set; }

        public Compra()
        {
            Fecha = DateTime.Now;
            Activo = true;
            CompraDetalle = new BindingList<CompraDetalle>();
        }

        public void CalcularTotalCompra()
        {
            var productosBL = new ProductosBL();

            double subtotal = 0;
            foreach (var detalle in CompraDetalle)
            {
                var precio = productosBL.ObtenerPrecio(detalle.ProductoId);

                subtotal = subtotal + detalle.CalcularTotalDetalle(precio);
            }

            Subtotal = subtotal;
            Impuesto = Subtotal * 0.15;
            Total = Subtotal + Impuesto;
        }

    }

    public class CompraDetalle
    {
        public int Id { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }

        public CompraDetalle()
        {
            Cantidad = 1;
            ProductoId = 1;
        }

        public double CalcularTotalDetalle(double precio)
        {
            Precio = precio;
            Total = Cantidad * Precio;

            return Total;
        }
    }
}
