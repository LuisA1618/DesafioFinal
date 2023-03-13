using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_final
{
    class Prenda
    {
        private bool calidad;
        private int stock;
        private float precioOf = 100;
        private float cantidad;
        private bool validar;

        public bool Calidad { get => calidad; set => calidad = value; }
        public int Stock { get => stock; set => stock = value; }
        public float Cantidad { get => cantidad; set => cantidad = value; }
        public bool Validar { get => validar; set => validar = value; }
        public float PrecioOf { get => precioOf; set => precioOf = value; }
    }
}
