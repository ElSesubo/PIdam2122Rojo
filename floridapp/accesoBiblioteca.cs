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
            List<biblioteca> portatil = new List<biblioteca>();

            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                portatil = biblioteca.ListaBiblioteca();
                conexion.CerrarConexion();
            }
            dtgvReservas.Rows.Clear();
            for (int i = 0; i < portatil.Count; i++)
            {
                dtgvReservas.Rows.Add(portatil[i].Id, portatil[i].Hora, portatil[i].Id_portatil, portatil[i].Id_user, portatil[i].Dia_hora_reserva);
            }
        }

        private void accesoBiblioteca_Load_1(object sender, EventArgs e)
        {
            cargarPortatiles();
            Cargar();
        }

        private void btnInserta_Click(object sender, EventArgs e)
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
                        biblioteca.EliminaRegistro(id);
                        conexion.CerrarConexion();
                        conexion.AbrirConexion();
                        biblioteca.ActualizarPortatilDevuelto(id);
                        conexion.CerrarConexion();
                    }
                    Cargar();
                }
            }
        }

        private void cargarPortatiles()
        {
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
    }
}
