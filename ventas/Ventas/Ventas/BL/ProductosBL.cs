using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ProductosBL
    {
        public BindingList<Producto> ListadeProductos { get; set; }

        public ProductosBL()
        {
            ListadeProductos = new BindingList<Producto>();
            CrearDatosdePrueba();
        }

        public double ObtenerPrecio(int id)
        {
            double precio = 0;

            foreach (var producto in ListadeProductos)
            {
                if (producto.Id == id)
                {
                    precio = producto.Precio;
                }
            }

            return precio;
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptops");
            var categoria2 = new Categoria(2, "Accesorios");

            var producto1 = new Producto(1, "Laptop Dell", 15000, categoria1);

            var fileInfo = new FileInfo(@"C:\Users\marco\OneDrive\Documentos\Proyectos L2\ventas\imagenes\Dell.jpg");
            var fileStream = fileInfo.OpenRead();

            producto1.Foto = Program.imageToByteArray(Image.FromStream (fileStream));

            var producto2 = new Producto(2, "Laptop Asus", 20000, categoria1);

             fileInfo = new FileInfo(@"C:\Users\marco\OneDrive\Documentos\Proyectos L2\ventas\imagenes\Asus.jpg");
             fileStream = fileInfo.OpenRead();

            producto2.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

           var producto3 = new Producto(3, "Mouse Logitech", 200, categoria2);

             fileInfo = new FileInfo(@"C:\Users\marco\OneDrive\Documentos\Proyectos L2\ventas\imagenes\Logitech.jpg");
             fileStream = fileInfo.OpenRead();

            producto3.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var producto4 = new Producto(4, "Teclado Logitech", 550, categoria2);

            fileInfo = new FileInfo(@"C:\Users\marco\OneDrive\Documentos\Proyectos L2\ventas\imagenes\TecladoLogitech.jpg");
            fileStream = fileInfo.OpenRead();

            producto4.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var producto5 = new Producto(5, "Auricular Logitech", 800, categoria2);

            fileInfo = new FileInfo(@"C:\Users\marco\OneDrive\Documentos\Proyectos L2\ventas\imagenes\AuricularesLogitech.jpg");
            fileStream = fileInfo.OpenRead();

            producto5.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var producto6 = new Producto(6, "Mouse Gaming", 400, categoria2);

            fileInfo = new FileInfo(@"C:\Users\marco\OneDrive\Documentos\Proyectos L2\ventas\imagenes\MouseGamer.jpg");
            fileStream = fileInfo.OpenRead();

            producto6.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var producto7 = new Producto(7, "Gabinete Gaming", 3500, categoria2);

            fileInfo = new FileInfo(@"C:\Users\marco\OneDrive\Documentos\Proyectos L2\ventas\imagenes\GabineteGamer.jpg");
            fileStream = fileInfo.OpenRead();

            producto7.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var producto8 = new Producto(8, "PC Gaming", 23000, categoria2);

            fileInfo = new FileInfo(@"C:\Users\marco\OneDrive\Documentos\Proyectos L2\ventas\imagenes\PCGamer.jpg");
            fileStream = fileInfo.OpenRead();

            producto8.Foto = Program.imageToByteArray(Image.FromStream(fileStream));


            var producto9 = new Producto(9, "Laptop Gaming", 25000, categoria1);

            fileInfo = new FileInfo(@"C:\Users\marco\OneDrive\Documentos\Proyectos L2\ventas\imagenes\LaptopGamer.jpg");
            fileStream = fileInfo.OpenRead();

            producto9.Foto = Program.imageToByteArray(Image.FromStream(fileStream));
            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);
            ListadeProductos.Add(producto4);
            ListadeProductos.Add(producto5);
            ListadeProductos.Add(producto6);
            ListadeProductos.Add(producto7);
            ListadeProductos.Add(producto8);
            ListadeProductos.Add(producto9);

        }
    }
}
