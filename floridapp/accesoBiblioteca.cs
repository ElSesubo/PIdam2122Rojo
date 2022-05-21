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
    public partial class accesoBiblioteca : Form
    {
        public accesoBiblioteca()
        {
            InitializeComponent();
        }

        /*private void CargaListaReservas()
        {
            string seleccion = "Select * from reserva_biblioteca";
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                dtgvReservas.DataSource = biblioteca.BuscarRegistro(seleccion);
                conexion.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }
        }*/

        private void accesoBiblioteca_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dtgvReservas.SelectedRows.Count == 1)
            {
                int id = (Convert.ToInt32(dtgvReservas.CurrentRow.Cells[0].Value));



                DialogResult confirmacion = MessageBox.Show("Vaciar la mesa el registro seleccionado. ¿Continuar?",
                                                    "Eliminación", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        biblioteca.EliminaRegistro(id);
                        conexion.CerrarConexion();
                    }
                    Cargar();
                }
            }
            /*try
            {
                int resultado;

                if (dtgvReservas.SelectedRows.Count == 1) 
                {
                    int idUsuario = (int)dtgvReservas.CurrentRow.Cells[0].Value;

                    DialogResult confirmacion = MessageBox.Show("Borrado de registro seleccionado. ¿Continuar?",
                                                "Eliminación", MessageBoxButtons.YesNo);

                    if (confirmacion == DialogResult.Yes)
                    {
                        if (conexion.Conexion != null)
                        {
                            conexion.AbrirConexion();
                            resultado = biblioteca.EliminaRegistro(idUsuario);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                        }
                        conexion.CerrarConexion();
                        //CargaListaReservas();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dtgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cargar()
        {
            List<biblioteca> porta = new List<biblioteca>();

            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                porta = biblioteca.ListaBiblioteca();
                conexion.CerrarConexion();
            }
            dtgvReservas.Rows.Clear();
            for (int i = 0; i < porta.Count; i++)
            {
                dtgvReservas.Rows.Add(porta[i].Id, porta[i].Hora, porta[i].Id_portatil, porta[i].Id_user, porta[i].Dia_hora_reserva);
            }

            List<portatil> port = new List<portatil>();

            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                port = portatil.ListaPortatiles();
                conexion.CerrarConexion();
            }
            dtgvPortatiles.Rows.Clear();
            for (int i = 0; i < port.Count; i++)
            {
                dtgvPortatiles.Rows.Add(port[i].Id, port[i].Reservado, port[i].Devuelto);
            }
        }

        private void accesoBiblioteca_Load_1(object sender, EventArgs e)
        {
            cargarPortatiles();
            Cargar();
        }

        private bool ValidarDatos()
        {
            bool ok = true;
            if (comboBox1.SelectedIndex == -1)
            {
                ok = false;
                errorProvider1.SetError(comboBox1, "SELECIONE EL PORTATIL");
            }
            else if (usuario.CheckNIF(txtNIF.Text.ToUpper()) == false)
            {
                ok = false;
                errorProvider1.SetError(txtNIF, "LETRA DEL NIF INCORRECTA");
            }
            else if (usuario.ComprobarNIF(txtNIF.Text.ToUpper()) == false)
            {
                ok = false;
                errorProvider1.SetError(dtpHoraReserva, "EL USUARIO YA EXISTE");
            }
            else if (dtpHoraReserva.Value < DateTime.Now)
            {
                ok = false;
                errorProvider1.SetError(dtpHoraReserva, "HORA INCORRECTA");
            }
            else
            {
                errorProvider1.Clear();
            }
            return ok;
        }

        private void btnInserta_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                TimeSpan hora = TimeSpan.Parse(dtpHoraReserva.Value.ToString("T"));
                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    biblioteca.ActualizarPortatilReserva(Convert.ToInt32(comboBox1.Text));
                    conexion.CerrarConexion();
                    conexion.AbrirConexion();
                    biblioteca.InsertarPedidoBiblioteca(hora, Convert.ToInt32(comboBox1.Text), txtNIF.Text);
                    conexion.CerrarConexion();
                }
                Cargar();
                cargarPortatiles();
            }
        }

        private void btnDevuelto_Click(object sender, EventArgs e)
        {
            if (dtgvReservas.SelectedRows.Count == 1)
            {
                int id = (Convert.ToInt32(dtgvReservas.CurrentRow.Cells[2].Value));



                DialogResult confirmacion = MessageBox.Show("Portatil sin devolver en el registro seleccionado. ¿Continuar?",
                                                    "Eliminación", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        biblioteca.ActualizarPortatilDevuelto(id);
                        conexion.CerrarConexion();
                        conexion.AbrirConexion();
                        biblioteca.EliminaRegistro(id);
                        conexion.CerrarConexion();
                    }
                }
            }
            Cargar();
            cargarPortatiles();
        }

        private void cargarPortatiles()
        {
            comboBox1.Items.Clear();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                List<string> ciclos = biblioteca.cargar_portatiles();
                for (int i = 0; i<ciclos.Count; i++)
                {
                    comboBox1.Items.Add(ciclos[i]);
                }
                conexion.CerrarConexion();
            }
            comboBox1.SelectedIndex = 0;
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                portatil.AgregarPortatil();
                conexion.CerrarConexion();
            }
            Cargar();
            cargarPortatiles();
        }
    }
}
