using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_final
{
    class Pantalon: Prenda
    {
        private bool comunes;

        public bool Comunes { get => comunes; set => comunes = value; }
        public bool Chupines { get => chupines; set => chupines = value; }
        public float Precio { get => precio; set => precio = value; }

        private bool chupines;
        private float precio;
        public void PrecioCotizar(float CantidadPant)
        {
            precio = PrecioOf;
            if (Chupines)
            {
                precio = (PrecioOf - ((PrecioOf / 100) * 12));
            }
            if (!Chupines)
            {
                precio = PrecioOf;
            }
            if (Calidad)
            {
                precio = (precio + ((precio / 100) * 30));
            }
            precio = precio * CantidadPant;
        }

        internal bool Validacion(float CantidadPant)
        {
            if (

                (Chupines && CantidadPant <= 750) ||
                (!Chupines && CantidadPant <= 250)

                )
            {
                Validar = true;
            }
            else
            {
                Validar = false;
            }

            return Validar;
        }
    }
}
