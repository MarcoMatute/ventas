﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.modelos;

namespace WindowsFormsApplication3.BL
{
    public class CiudadBL
    {
        public BindingList<Ciudad> ListadeCiudades { get; set; }

        public CiudadBL()
        {
            ListadeCiudades = new System.ComponentModel.BindingList<Ciudad>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Comayagua");
            var ciudad2 = new Ciudad(2, "Puerto Cortes");

            ListadeCiudades.Add(ciudad1);
            ListadeCiudades.Add(ciudad2);
        }

    }
}
