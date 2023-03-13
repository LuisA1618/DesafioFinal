using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_final
{
    class Camisa: Prenda
    {
        private bool mangacorta;

        public bool Mangacorta { get => mangacorta; set => mangacorta = value; }


        private bool cuellomao;

        public bool Cuellomao { get => cuellomao; set => cuellomao = value; }
        public float Precio { get => precio; set => precio = value; }

        private float precio = 100;

        public void PrecioCotizar(float CantidadCam)
        {

            if (!Cuellomao && !Mangacorta)
            {
                precio = PrecioOf;
            }
            if (!Cuellomao && Mangacorta)
            {
                precio = (PrecioOf - ((PrecioOf / 100) * 10));
            }

            if (Cuellomao && !Mangacorta)
            {
                precio = (PrecioOf + ((PrecioOf / 100) * 3));
            }
            if (Cuellomao && Mangacorta)
            {
                precio = (PrecioOf - ((PrecioOf / 100) * 10));
                precio = (precio + ((precio / 100) * 3));
            }
            if (Calidad)
            {
                precio = precio + ((precio / 100) * 30);
            }

            Precio = Precio * CantidadCam;
        }
        internal bool Validacion(float CantidadCam)
        {
            if (

                (Mangacorta && Cuellomao && CantidadCam <= 100) ||
                (Mangacorta && !Cuellomao && CantidadCam <= 150) ||
                (!Mangacorta && Cuellomao && CantidadCam <= 75) ||
                (!Mangacorta && !Cuellomao && CantidadCam <= 175)

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
