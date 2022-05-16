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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                dtgvReservas.DataSource = biblioteca.BuscarRegistroId(Convert.ToInt32(txtId.Text));
                conexion.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de Datos");
            }
        }

        private void CargaListaReservas()
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
        }

        private void accesoBiblioteca_Load(object sender, EventArgs e)
        {
            CargaListaReservas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvReservas.SelectedRows.Count == 1) 
                {
                    int idUsuario = (int)dtgvReservas.CurrentRow.Cells[0].Value;  
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        biblioteca reg =  biblioteca.ObtenerUsuario(idUsuario);
                        txtId.Text = reg.Id.ToString();
                        dtpReserva.Value = reg.Dia_hora_reserva;
                        txtIdPortatil.Text = reg.Id_portatil.ToString();
                        txtIdPecera.Text = reg.Id_pecera.ToString();
                        txtNIF.Text = reg.Id_user;
                        dtpDevolucion.Value = reg.Dia_hora_devolucion;
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
                        CargaListaReservas();
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
            CargaListaReservas();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
