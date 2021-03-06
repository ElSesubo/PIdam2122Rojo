using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Globalization;
using floridapp.RecursoL;

namespace floridapp.UserControls
{
    public partial class RealizarReunion : UserControl
    {
        public RealizarReunion()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            profesor.modulo = cmbCiclo.SelectedItem.ToString();
            //RealizarReunionFormulario reu = new RealizarReunionFormulario();
            //addUserControl(reu);
            if (!Form1.Instance.panelV.Controls.ContainsKey("RealizarReunionFormulario"))
            {
                RealizarReunionFormulario ruf = new RealizarReunionFormulario();
                ruf.Dock = DockStyle.Fill;
                Form1.Instance.panelV.Controls.Add(ruf);
            }
            Form1.Instance.panelV.Controls["RealizarReunionFormulario"].BringToFront();

        }


        private void RealizarReunion_Load(object sender, EventArgs e)
        {

            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                List<string> ciclos = usuario.cargar_modulos();
                for (int i = 0; i < ciclos.Count; i++)
                {
                    cmbCiclo.Items.Add(ciclos[i]);
                }
                conexion.CerrarConexion();
            }
            cmbCiclo.SelectedIndex = 0;
            cargar_idioma();
            
        }

        private void AplicarIdioma()
        {
            label1.Text = RecursoL.Resources.rreu1;
            label2.Text = RecursoL.Resources.rreu2;
            btnContinuar.Text = RecursoL.Resources.rreu3;
        }
        private void cargar_idioma()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura.Nombre);
            AplicarIdioma();
        }
        private void cmbCiclo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void addUserControl(UserControl userControl)
        //{
        //    userControl.Dock = DockStyle.Fill;
        //    userControl.BringToFront();
        //}
    }
}
