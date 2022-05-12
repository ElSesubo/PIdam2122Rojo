using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace floridapp
{
    public partial class Login : Form
    {
        Form1 inicio = new Form1();
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                if (usuario.MailExiste(txtCorreo.Text))
                {
                    int tipologin = usuario.VerifyUser(txtCorreo.Text, txtContraseña.Text);
                    switch (tipologin)
                    {
                        case 1:
                            MessageBox.Show("Login profesor.");
                            break;
                        case 2:
                            inicio.Show();
                            break;
                        case 3:
                            MessageBox.Show("Login del administrador");
                            break;
                        case 4:
                            MessageBox.Show("Login cafeteria,");
                            break;
                        case 5:
                            MessageBox.Show("Login biblioteca,");
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

                conexion.CerrarConexion();
                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    string nif = usuario.BuscarNIF(txtCorreo.Text);
                    MessageBox.Show(nif);
                    conexion.CerrarConexion();
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
    }
}
