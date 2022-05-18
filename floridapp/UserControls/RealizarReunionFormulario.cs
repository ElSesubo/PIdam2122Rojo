using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace floridapp.UserControls
{
    public partial class RealizarReunionFormulario : UserControl
    {
        private profesor profesor=new profesor();
        public RealizarReunionFormulario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RealizarReunionFormulario_Load(object sender, EventArgs e)
        {
            dtpDia.Value = DateTime.Now;
            refresh();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                lblprofesor.Text = profesor.cargar_profesor_modulos();
                conexion.CerrarConexion();
            }

        }

        private void refresh()
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                cmbHoras.DataSource = profesor.filtrar_horas_por_dias(dtpDia.Value);
                conexion.CerrarConexion();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_ci = 0;
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                id_ci = profesor.buscar_ciclo();
                conexion.CerrarConexion();
            }
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                try
                {
                    profesor.realizar_reserva_profesor(dtpDia.Value, cmbHoras.SelectedItem.ToString(), id_ci);
                    MessageBox.Show("Reserva realizado con exito.");
                }catch (Exception ex)
                {
                    MessageBox.Show("Error al reservar.");
                }
                
                conexion.CerrarConexion();
            }
            refresh();
        }

        //Este metodo servia para obtener el indice de las horas ocupadas para los siguientes metodos.

        //private List<int> obtenerindice()
        //{
        //    List<int> horas = new List<int>();
        //    if (conexion.Conexion != null)
        //    {
        //        conexion.AbrirConexion();
        //        horas = profesor.buscar_indice(dtpDia.Value);
        //        conexion.CerrarConexion();
        //    }
        //    return horas;
        //}



        //Este metodo servia para pintar de blanco las horas ocupadas, pero vimos que sobrecargaba al sistema y decidimos buscar otra forma.

        //private void cmbHoras_DrawItem(object sender, DrawItemEventArgs e)
        //{

        //    //if (e.Index != -1)
        //    //{
        //    //    e.DrawBackground();

        //    //    e.Graphics.DrawString(((ComboBox)sender).Items[e.Index].ToString(),
        //    //        ((ComboBox)sender).Font,
        //    //        (obtenerindice().Contains(e.Index)) ? Brushes.Black : Brushes.LightGray,
        //    //        e.Bounds);
        //    //}
        //}

        private void cmbHoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Este metodo mo te dejaba seleccionar las casillas pintadas de blanco del metodo anterior.

            //if (obtenerindice().Contains(cmbHoras.SelectedIndex))
            //{
            //    cmbHoras.SelectedIndex = -1;
            //}
        }

        private void dtpDia_ValueChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
