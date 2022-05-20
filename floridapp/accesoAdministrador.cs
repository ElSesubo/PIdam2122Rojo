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
    public partial class accesoAdministrador : Form
    {
        public accesoAdministrador()
        {
            InitializeComponent();
            dtgvUsuarios.ReadOnly = true;
        }

        private void accesoAdministrador_Load(object sender, EventArgs e)
        {
            CargaListaUsuarios();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargaListaUsuarios()
        {
            string seleccion = "Select * from usuario";
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                dtgvUsuarios.DataSource = usuario.BuscarUsuario(seleccion);
                conexion.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }
            dtgvUsuarios.ReadOnly = true;
            gbCiclo.Visible = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int resultado;

            try
            {
                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    usuario usu = new usuario();
                    usu.Nif = txtNif.Text;
                    usu.Correo = txtCorreo.Text;
                    usu.Contraseña = txtContra.Text;
                    usu.Nombre = txtNombre.Text;
                    usu.Apellido = txtApellido.Text;
                    usu.Tel = Convert.ToInt32(txtTel.Text);
                    usu.Alumno = rbnAlumno.Checked;
                    usu.Admi = rbnAdmin.Checked;
                    usu.Profesor = rbnProfesor.Checked;
                    usu.Cocina = rbnCocina.Checked;
                    usu.Biblioteca = rbnBiblioteca.Checked; 

                    if (!usuario.MailExiste(txtCorreo.Text)) 
                    {
                        resultado = usu.AgregarUsuario(usu);
                    }
                    else 
                    {
                        usu.Nif = txtNif.Text;
                        resultado = usu.ActualizaUsuario(usu);
                    }

                    if (resultado > 0) 
                    {
                        txtNif.Clear();
                        txtCorreo.Clear();
                        txtContra.Clear();
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtTel.Clear();
                        rbnAdmin.Checked = false;
                        rbnAlumno.Checked = false;
                        rbnProfesor.Checked = false;
                        rbnCocina.Checked = false;
                        rbnBiblioteca.Checked = false; 
                        txtNif.Focus();
                    }

                    conexion.CerrarConexion();
                    CargaListaUsuarios();

                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally  
            {
                conexion.CerrarConexion();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                dtgvUsuarios.DataSource = usuario.BuscarUsuario(txtNif.Text);
                conexion.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de Datos");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvUsuarios.SelectedRows.Count == 1) 
                {
                    string nif = (string)dtgvUsuarios.CurrentRow.Cells[0].Value;  
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        usuario usu = usuario.ObtenerUsuario(nif);
                        txtNif.Text = usu.Nif;
                        txtCorreo.Text = usu.Correo;
                        txtContra.Text = usu.Contraseña;
                        txtNombre.Text = usu.Nombre;
                        txtApellido.Text = usu.Apellido;
                        txtTel.Text = usu.Tel.ToString();
                        rbnProfesor.Checked = usu.Profesor;
                        rbnAdmin.Checked = usu.Admi;
                        rbnCocina.Checked = usu.Cocina;
                        rbnBiblioteca.Checked = usu.Biblioteca;
                        rbnAlumno.Checked = usu.Alumno; 
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                    }
                    conexion.CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado;

                if (dtgvUsuarios.SelectedRows.Count == 1) 
                {
                    string nif = (string)dtgvUsuarios.CurrentRow.Cells[0].Value;
                    DialogResult confirmacion = MessageBox.Show("Borrado de registro seleccionado. ¿Continuar?",
                                                "Eliminación", MessageBoxButtons.YesNo);

                    if (confirmacion == DialogResult.Yes)
                    {
                        if (conexion.Conexion != null)
                        {
                            conexion.AbrirConexion();
                            resultado = usuario.EliminaUsuario(nif);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                        }
                        conexion.CerrarConexion();
                        CargaListaUsuarios();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargaListaUsuarios();
        }

        private void cbProfesor_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void dtgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbnProfesor_CheckedChanged(object sender, EventArgs e)

        {
            gbCiclo.Visible=true;
        }
    }
}
