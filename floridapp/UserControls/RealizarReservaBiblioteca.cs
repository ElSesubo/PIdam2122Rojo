using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using floridapp.RecursoL;

namespace floridapp.UserControls
{
    public partial class RealizarReservaBiblioteca : UserControl
    {
        public RealizarReservaBiblioteca()
        {
            InitializeComponent();
        }

        private void RealizarReservaBiblioteca_Load(object sender, EventArgs e)
        {
            cargar_idioma();
        }

        private void AplicarIdioma()
        {
            lbl1.Text = Resources.rrb1;
            label2.Text= Resources.rrb2;
            cbPortatil.Text= Resources.rrb3;
            label4.Text= Resources.rrb4;
            button1.Text= Resources.rrb5;

        }
        private void cargar_idioma()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura.Nombre);
            AplicarIdioma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool portatil = cbPortatil.Checked;
            TimeSpan hora= TimeSpan.Parse(dtpHora.Value.ToString("T"));
            if (portatil == cbPortatil.Checked)
            {
                int id = 0;
                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    id = biblioteca.BuscarPortatilDisponible();
                    conexion.CerrarConexion();
                }
                
                string nif = "";

                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    nif = usuario.BuscarNIF(usuario.Email);
                    conexion.CerrarConexion();
                }
                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    biblioteca.InsertarPedidoBiblioteca(hora,id,nif);
                    conexion.CerrarConexion();
                }
                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    biblioteca.ActualizarPortatilReserva(id);
                    conexion.CerrarConexion();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSala.Checked == false)
            {
                cbSalas.Enabled = false;
            }
            else
            {
                cbSalas.Enabled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
