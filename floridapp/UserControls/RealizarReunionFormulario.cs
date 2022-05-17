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
            refresh();


        }

        private void refresh()
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                lblprofesor.Text = profesor.cargar_profesor_modulos();
                conexion.CerrarConexion();
            }
            cmbHoras.DataSource = profesor.Lista_horas;
            for(int i = 0; i < obtenerindice().Count; i++)
            {
                cmbHoras.Items.Remove(obtenerindice()[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                try
                {
                    profesor.realizar_reserva_profesor(dtpDia.Value, cmbHoras.SelectedItem.ToString());
                    MessageBox.Show("Reserva realizado con exito.");
                }catch (Exception ex)
                {
                    MessageBox.Show("Error al reservar.");
                }
                
                conexion.CerrarConexion();
            }
        }

        private List<int> obtenerindice()
        {
            List<int> horas = new List<int>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                horas = profesor.indices(dtpDia.Value);
                conexion.CerrarConexion();
            }
            return horas;
        }
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

            
            //if (obtenerindice().Contains(cmbHoras.SelectedIndex))
            //{
            //    cmbHoras.SelectedIndex = -1;
            //}
        }

        private void dtpDia_ValueChanged(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
