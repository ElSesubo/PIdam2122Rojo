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
            dtgvUsuarios1.ReadOnly = true;
        }

        private void accesoAdministrador_Load(object sender, EventArgs e)
        {
            CargaListaUsuarios();
            rbnAdmin.Checked = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargaListaUsuarios()
        {
            dtgvUsuarios1.Rows.Clear();
            string seleccion = "Select * from usuario";
            List<usuario>user=new List<usuario>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                user = usuario.BuscarUsuario(seleccion);
                conexion.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }
            for (int i = 0; i < user.Count; i++)
            {
                dtgvUsuarios1.Rows.Add(user[i].Nif, user[i].Correo, user[i].Contraseña, user[i].Nombre, user[i].Apellido, user[i].Tel, user[i].Alumno, user[i].Profesor, user[i].Cocina, user[i].Biblioteca, user[i].Admi);
            }
            dtgvUsuarios1.ReadOnly = true;
            gbCiclo.Visible = false;
        }

        private void limpiar()
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
                rbnAdmin.Checked=true;
        }
        private void insertar_usuario()
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
                        MessageBox.Show("Usuario insertado con exito.");
                    }
                    else
                    {
                        usu.Nif = txtNif.Text;
                        resultado = usu.ActualizaUsuario(usu);
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
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (rbnAlumno.Checked == true)
            {
                if (ValidarDatos3())
                {
                    insertar_usuario();
                    int id = buscar_id_ciclo();
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        try
                        {
                            usuario.insertarUsuarioCiclo(txtNif.Text, id);
                            limpiar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al insertar usuario al ciclo.");
                        }

                        conexion.CerrarConexion();
                    }
                }
                else
                {
                    dtgvUsuarios1.Rows.Clear();
                    cargar_ciclos();
                    gbCiclo.Visible = true;
                    gbCiclo.Focus();
                    cmbmodulo.Visible = false;
                    ValidarDatos3();
                }
            }
            else if (rbnProfesor.Checked == true)
            {
                if (ValidarDatos())
                {
                    insertar_usuario();
                    int id = buscar_id_ciclo();
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        try
                        {
                            usuario.insertarUsuarioCiclo(txtNif.Text, id);
                            MessageBox.Show("Usuario insertado al ciclo coin exito");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al insertar usuario al ciclo.");
                        }

                        conexion.CerrarConexion();
                    }
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        try
                        {
                            usuario.insertar_modulo_profesor(cmbmodulo.SelectedItem.ToString().ToUpper(),txtNif.Text.ToUpper(),id);
                            limpiar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al insertar profesor al ciclo.");
                        }

                        conexion.CerrarConexion();
                    }
                }
                else
                {
                    gbCiclo.Visible = true;
                    gbCiclo.Focus();
                    ValidarDatos3();
                }
            }

        }

        /*private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                dtgvUsuarios1.DataSource = usuario.BuscarUsuario(txtNif.Text);
                conexion.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de Datos");
            }
        }*/

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                    if (conexion.Conexion != null)
                    {
                    try
                    {
                        conexion.AbrirConexion();
                        usuario usu = new usuario(txtNif.Text, txtCorreo.Text, txtContra.Text, txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtTel.Text), rbnProfesor.Checked,
                            rbnAlumno.Checked, rbnAdmin.Checked, rbnCocina.Checked, rbnBiblioteca.Checked);
                        usu.ActualizaUsuario(usu);
                        MessageBox.Show("Se ha actualizado con exito");
                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    }
                    else
                    {
                        MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                    }
                    conexion.CerrarConexion();
                    CargaListaUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int eliminado=0;
            DialogResult resultado = MessageBox.Show("Desea eliminar usuario?", "ELIMINAR!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (txtNif.Text == "")
            {
                MessageBox.Show("Debes hacer click sobre el usuario que quieres eliminar en la tabla.");
            }
            else
            {
                if (resultado == DialogResult.Yes)
                {
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        try
                        {
                            eliminado=usuario.EliminaUsuario(txtNif.Text);
                            if (eliminado == 0)
                            {
                                MessageBox.Show("El nif introducido no existe.");
                            }
                            else
                            {
                                MessageBox.Show("Eliminado con exito.");
                                limpiar();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar.");
                        }

                        conexion.CerrarConexion();
                    }
                }
            }
            CargaListaUsuarios();
            
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
            int fila=e.RowIndex;
            txtNif.Text =dtgvUsuarios1.Rows[fila].Cells[0].Value.ToString();
            txtCorreo.Text = dtgvUsuarios1.Rows[fila].Cells[1].Value.ToString();
            txtContra.Text=dtgvUsuarios1.Rows[fila].Cells[2].Value.ToString();
            txtNombre.Text=dtgvUsuarios1.Rows[fila].Cells[3].Value.ToString();
            txtApellido.Text=dtgvUsuarios1.Rows[fila].Cells[4].Value.ToString();
            txtTel.Text=dtgvUsuarios1.Rows[fila].Cells[5].Value.ToString();
        }

        private void rbnProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (ValidarDatos2())
            {
                gbCiclo.Visible = true;
                lblmodulo.Visible = true;
                cmbmodulo.Visible = true;
                cargar_combobox();
            }
        }

        private void cargar_ciclos()
        {
            cmbciclo.Items.Clear();
            List<string> ciclo=new List<string>();
            if(conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                ciclo=usuario.lista_ciclos();
                conexion.CerrarConexion();
            }
            for(int i = 0; i < ciclo.Count; i++)
            {
                cmbciclo.Items.Add(ciclo[i]);
            }
        }
        private void cargar_clase()
        {
            List<string> ciclo = new List<string>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                ciclo = usuario.lista_clase(cmbciclo.SelectedItem.ToString());
                conexion.CerrarConexion();
            }
            for (int i = 0; i < ciclo.Count; i++)
            {
                cmbclase.Items.Add(ciclo[i]);
            }
        }
        private void cargar_horario()
        {
            List<string> ciclo = new List<string>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                ciclo = usuario.lista_horario(cmbciclo.SelectedItem.ToString(),cmbclase.SelectedItem.ToString(),cmbprensencia.SelectedItem.ToString());
                conexion.CerrarConexion();
            }
            for (int i = 0; i < ciclo.Count; i++)
            {
                cmbhorario.Items.Add(ciclo[i]);
            }
        }
        private void cargar_presencialidad()
        {
            List<string> ciclo = new List<string>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                ciclo = usuario.lista_presencialidad(cmbciclo.SelectedItem.ToString(),cmbclase.SelectedItem.ToString());
                conexion.CerrarConexion();
            }
            for (int i = 0; i < ciclo.Count; i++)
            {
                cmbprensencia.Items.Add(ciclo[i]);
            }
        }
        private int buscar_id_ciclo()
        {
            int id = 0;
            if(conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                id = usuario.filtrarCiclos(cmbciclo.SelectedItem.ToString(), cmbclase.SelectedItem.ToString(),cmbhorario.SelectedItem.ToString(),cmbprensencia.SelectedItem.ToString());
                conexion.CerrarConexion();
            }
            return id;
        }
        private void cargar_modulos()
        {
            List<string> modulo = new List<string>();
            int id = buscar_id_ciclo();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                modulo = usuario.lista_modulos(id);
                conexion.CerrarConexion();
            }
            for (int i = 0; i < modulo.Count; i++)
            {
                cmbmodulo.Items.Add(modulo[i]);
            }
        }
        private void cargar_combobox()
        {
            cargar_ciclos();
            cmbciclo.SelectedIndex = 0;

        }

        private void rbnAlumno_CheckedChanged(object sender, EventArgs e)
        {
            if (ValidarDatos2())
            {
                gbCiclo.Visible = true;
                lblmodulo.Visible = false;
                cmbmodulo.Visible = false;
                cargar_combobox();
            }
        }

        private void rbnCocina_CheckedChanged(object sender, EventArgs e)
        {
            gbCiclo.Visible=false;
        }

        private void rbnBiblioteca_CheckedChanged(object sender, EventArgs e)
        {
            gbCiclo.Visible = false;
        }

        private void rbnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            gbCiclo.Visible = false;
        }

        private void cmbciclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbclase.Items.Clear();
            cmbclase.Items.Clear();
            cmbprensencia.Items.Clear();
            cmbhorario.Items.Clear();
            cmbmodulo.Items.Clear();
            cargar_clase();
        }

        private void cmbprensencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbhorario.Items.Clear();
            cargar_horario();
        }

        private void cmbclase_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbprensencia.Items.Clear();
            cargar_presencialidad();
        }

        private void cmbhorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmodulo.Items.Clear();
            cargar_modulos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarDatos()&&rbnProfesor.Checked)
            {
                gbCiclo.Visible = false;
            }
            else if (ValidarDatos3() && rbnAlumno.Checked)
            {
                gbCiclo.Visible = false;
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
        private bool ValidarDatos()
        {
            bool ok = true;
            if (cmbclase.SelectedIndex == -1)
            {
                ok = false;
                errorProvider1.SetError(cmbclase, "SELECIONE LA CLASE");
            }
            else if (cmbprensencia.SelectedIndex == -1)
            {
                ok = false;
                errorProvider1.SetError(cmbprensencia, "SELECIONE UN TIPO");
            }
            else if (cmbhorario.SelectedIndex == -1)
            {
                ok = false;
                errorProvider1.SetError(cmbhorario, "SELECIONE EL HORARIO");
            }
            else if (cmbmodulo.SelectedIndex == -1)
            {
                ok = false;
                errorProvider1.SetError(cmbmodulo, "SELECIONE UN MODULO");
            }
            else
            {
                errorProvider1.Clear();
            }
            return ok;
        }
        private bool ValidarDatos2()
        {
            bool ok = true;
            if (txtNif.Text=="")
            {
                ok = false;
                errorProvider2.SetError(txtNif, "INTRODUCE NIF");
            }
            else if (txtCorreo.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtCorreo, "INTRODUCE CORREO");
            }
            else if (txtContra.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtContra, "INTRODUCE CONTRASEÑA");
            }
            else if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtNombre, "INTRODUCE NOMBRE");
            }
            else if (txtApellido.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtApellido, "INTRODUCE APELLIDO");
            }
            else if (txtTel.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtTel, "INTRODUCE TELEFONO");
            }
            else
            {
                errorProvider2.Clear();
            }
            return ok;
        }
        /// <summary>
        /// Valida datos de alumno
        /// </summary>
        /// <returns></returns>
        private bool ValidarDatos3()
        {
            bool ok = true;
            if (cmbclase.SelectedIndex == -1)
            {
                ok = false;
                errorProvider1.SetError(cmbclase, "SELECIONE LA CLASE");
            }
            else if (cmbprensencia.SelectedIndex == -1)
            {
                ok = false;
                errorProvider1.SetError(cmbprensencia, "SELECIONE UN TIPO");
            }
            else if (cmbhorario.SelectedIndex == -1)
            {
                ok = false;
                errorProvider1.SetError(cmbhorario, "SELECIONE EL HORARIO");
            }
            else
            {
                errorProvider1.Clear();
            }
            return ok;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbCiclo.Visible = false;
        }

        private void rbnProfesor_MouseClick(object sender, MouseEventArgs e)
        {
            if (ValidarDatos2())
            {
                gbCiclo.Visible = true;
                lblmodulo.Visible = true;
                cmbmodulo.Visible = true;
                cargar_combobox();
            }
        }


    }
}
