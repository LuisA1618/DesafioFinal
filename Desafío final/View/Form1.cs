using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Desafío_final
{
    public partial class Form1 : Form
    {
        List<string> historialLista = new List<string>();
        Presenter _presenter = new Presenter();
        string his;
        string separador = "________";
        float cantidad;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            his = his + textBox2.Text + " ";

            try
            {
                _presenter.Cantidad = float.Parse(textBox2.Text, CultureInfo.InvariantCulture.NumberFormat);
                cantidad = float.Parse(textBox2.Text, CultureInfo.InvariantCulture.NumberFormat);
            }
            catch
            {
                MessageBox.Show("Por favor insertar una cantidad válida");
                textBox1.Text = "1";
            }


            //Calidad

            if(checkBox3.Checked == true)
            {
                _presenter.Calidad = true;
                his = his + " Premium";
            }
            else
            {
                _presenter.Calidad = false;
            }

            //Camisas
            if (radioButton1.Checked == true)
            {
                his = his + " Camisas";
                if (checkBox1.Checked == true)
                {
                    _presenter.MangaCorta = true;
                    his = his + "/ manga corta";
                }
                else
                {
                    _presenter.MangaCorta = false;
                }

                if (checkBox5.Checked == true)
                {
                    _presenter.CuelloMao = true;
                    his = his + "/ cuello mao";
                }
                else
                {
                    _presenter.CuelloMao = false;
                }
                if ((checkBox1.Checked == true) && (checkBox5.Checked == true))
                {
                    _presenter.MangaCorta = true;
                    _presenter.CuelloMao = true;
                }

                    _presenter.CotizarCam(cantidad);
                    textBox1.Text = _presenter.Precio + "";

                if(_presenter.Validar == true)
                {
                    his = his + " /" + _presenter.Precio + "$";
                }
                else
                {
                    his = his + " No hay stock";
                }
            }

            //Pantalones
            if (radioButton2.Checked == true)
            {
                his = his + " Pantalones";
                if (checkBox8.Checked == true)
                {
                    _presenter.PantalonChup = true;
                    his = his + "/ Chupines";
                }
                else
                {
                    _presenter.PantalonChup = false;
                }

                    _presenter.CotizarPant(cantidad);
                    textBox1.Text = _presenter.Precio + "";

                if (_presenter.Validar == true)
                {
                    his = his + " /" + _presenter.Precio + "$";
                }
                else
                {
                    his = his + " No hay stock";
                }
            }

            historialLista.Add(_presenter.TiendaCodigo());
            historialLista.Add(_presenter.TiendaNombre());
            historialLista.Add(_presenter.TiendaVendedor());
            historialLista.Add(his);
            historialLista.Add(separador);
            listBox1.DataSource = null;
            listBox1.DataSource = historialLista;
            his = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = _presenter.TiendaNombre();
            label8.Text = _presenter.TiendaVendedor();
            label11.Text = _presenter.TiendaCodigo();
        }
    }
}
