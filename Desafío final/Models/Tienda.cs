using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_final
{
    class Tienda
    {
        private string nombre = "Tienda de Luis";
        private string vendedor = "Luis Aguilar";
        private string codigo = "161821";

        public string Nombre { get => nombre; set => nombre = value; }
        public string Vendedor { get => vendedor; set => vendedor = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
