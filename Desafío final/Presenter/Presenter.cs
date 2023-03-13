using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Desafío_final
{
    class Presenter
    {
        Tienda tienda = new Tienda();
        Pantalon pantalon = new Pantalon();
        Camisa camisa = new Camisa();
        private bool mangaCorta;
        private bool cuelloMao;
        private float precio;
        private string error = "Error";
        private bool pantalonChup;
        private bool validar = true;
        private float cantidad;
        private bool calidad;
        public bool MangaCorta { get => mangaCorta; set => mangaCorta = value; }
        public bool CuelloMao { get => cuelloMao; set => cuelloMao = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Error { get => error; set => error = value; }
        public bool PantalonChup { get => pantalonChup; set => pantalonChup = value; }
        public bool Validar { get => validar; set => validar = value; }
        public float Cantidad { get => cantidad; set => cantidad = value; }
        public bool Calidad { get => calidad; set => calidad = value; }

        public void CotizarCam(float CantidadCam)
        {
            if (calidad == true)
            {
                camisa.Calidad = true;
            }
            else
            {
                camisa.Calidad = false;
            }
            if (MangaCorta == true)
            {
                    camisa.Mangacorta = true;
            }
            else
            {
                camisa.Mangacorta = false;
            }

            if (CuelloMao == true)
            {
                    camisa.Cuellomao = true;
            }
            else
            {
                camisa.Cuellomao = false;
            }
            if ((MangaCorta == true) && (CuelloMao == true))
            {
                camisa.Mangacorta = true;
                camisa.Cuellomao = true;
            }
            if (camisa.Validacion(CantidadCam) == true)
            {
                camisa.PrecioCotizar(CantidadCam);
                precio = camisa.Precio;
                validar = true;
            }
            else
            {
                MessageBox.Show("No hay suficiente stock");
                validar = false;
            }
            
        }
        public void CotizarPant(float CantidadPant)
        {
            if (calidad == true)
            {
                pantalon.Calidad = true;
            }
            else
            {
                pantalon.Calidad = false;
            }
            if (PantalonChup)
            {
                pantalon.Chupines = true;
            }
            else
            {
                pantalon.Chupines = false;
            }
            if (pantalon.Validacion(CantidadPant) == true)
            {
                pantalon.PrecioCotizar(CantidadPant);
                precio = pantalon.Precio;
                validar = true;
            }
            else
            {
                MessageBox.Show("No hay suficiente stock");
                validar = false;
            }
        }

        public string TiendaNombre()
        {
            string nombre;
            nombre = tienda.Nombre;
            return nombre;
        }
        public string TiendaVendedor()
        {
            string nombre;
            nombre = tienda.Vendedor;
            return nombre;
        }
        public string TiendaCodigo()
        {
            string nombre;
            nombre = tienda.Codigo;
            return nombre;
        }
    }
}
