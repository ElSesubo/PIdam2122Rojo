﻿using System;
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
        accesoAdministrador admi= new accesoAdministrador();
        accesoBiblioteca biblio= new accesoBiblioteca();
        accesoCocina cocina= new accesoCocina();
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                            MessageBox.Show("Login como profesor.");
                            inicio.Show();
                            break;
                        case 2:
                            usuario.Tipo = 2;
                            inicio.Show();
                            break;
                        case 3:
                            admi.Show();
                            break;
                        case 4:
                            cocina.Show();
                            break;
                        case 5:
                            biblio.Show();
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
    }
}
