using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelos
{
    public class Proveedores
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }

        public Proveedores()
        {
            Ciudad = new Ciudad(1, "San Pedro Sula");
            CiudadId = Ciudad.Id;
        }

        public Proveedores(int id, string nombre,string contacto, string telefono, string direccion, Ciudad ciudad)
        {
            Id = id;
            Nombre = nombre;
            Contacto = contacto;
            Telefono = telefono;
            Direccion = direccion;
            Ciudad = ciudad;
            CiudadId = ciudad.Id;
        }
    }
}
