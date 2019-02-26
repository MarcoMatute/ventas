using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientesproy.Modelos
{
    class Cliente
    {
        public int Id { get; set; }
        public string  Nombre { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }



        public Cliente(int id, string nombre, Categoria Categoria)
        {
            Id = id;
            Nombre = nombre;
            CategoriaId = Categoria.Id;
        }
    }
}
