using Clientesproy.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientesproy.BL
{
    public class CiudadBL
    {

        public List<Ciudad> listadeciudad { get; set; }

        public CiudadBL()
        {
            listadeciudad = new List<Ciudad>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad("San Pedro Sula");
            var ciudad2 = new Ciudad("Tegucigalpa");

            listadeciudad.Add(ciudad1);
            listadeciudad.Add(ciudad2);


        }
    }
}
