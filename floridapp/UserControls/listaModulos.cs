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
    public partial class listaModulos : UserControl
    {
        public listaModulos()
        {
            InitializeComponent();
        }

        private void listaModulos_Load(object sender, EventArgs e)
        {
            cargar_idioma();
            refresh();
        }
        private void refresh()
        {
            dtgvProfesores.Rows.Clear();
            List<usuario> user = new List<usuario>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                user = usuario.contacto_del_profesor();
                conexion.CerrarConexion();
            }
            for (int i = 0; i < user.Count; i++)
            {
                dtgvProfesores.Rows.Add(user[i].Nombre, user[i].Tel, user[i].Correo);
            }
            List<string> lista = new List<string>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                lista = usuario.lista_modulos();
                conexion.CerrarConexion();
            }
            for (int i = 0; i < lista.Count; i++)
            {
                cbCiclos.Items.Add(lista[i]);
            }
            cbCiclos.SelectedIndex = 0;
        }
        private void AplicarIdioma()
        {
            label1.Text = Resources.lm1;
            label2.Text = Resources.lm2;
            label3.Text = Resources.lm3;
            btnBuscar.Text = Resources.lm4;
           
        }
        private void cargar_idioma()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura.Nombre);
            AplicarIdioma();
        }

        private void dtgvProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtgvProfesores.Rows.Clear();
            List<usuario> user = new List<usuario>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                user = usuario.contacto_del_profesor(cbCiclos.SelectedItem.ToString());
                conexion.CerrarConexion();
            }
            for (int i = 0; i < user.Count; i++)
            {
                dtgvProfesores.Rows.Add(user[i].Nombre, user[i].Tel, user[i].Correo);
            }
        }
    }
}
