using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using floridapp.RecursoL;

namespace floridapp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            accesoAdministrador admi = new accesoAdministrador();
            accesoBiblioteca biblio = new accesoBiblioteca();
            accesoCocina cocina = new accesoCocina();

            usuario.Email = txtCorreo.Text;
            usuario.Tipo = 0;
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                if (usuario.MailExiste(txtCorreo.Text))
                {
                    int tipologin = usuario.VerifyUser(txtCorreo.Text, txtContraseña.Text);
                    conexion.CerrarConexion();
                    switch (tipologin)
                    {
                        case 1:
                            usuario.Tipo = 1;
                            inicio.ShowDialog();
                            break;
                        case 2:
                            usuario.Tipo = 2;
                            inicio.ShowDialog();
                            break;
                        case 3:
                            admi.ShowDialog();
                            break;
                        case 4:
                            cocina.ShowDialog();
                            break;
                        case 5:
                            biblio.ShowDialog();
                            break;
                        default:
                            MessageBox.Show("Error al iniciar sesion");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("No existe");
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void AplicarIdioma()
        {
            lblcorreo.Text = RecursoL.Resources.locor;
            lblcontraseña.Text = RecursoL.Resources.locon;
            btnSalir.Text = RecursoL.Resources.losal;
            btnentrar.Text = RecursoL.Resources.loent;
        }
       
    }
}
