using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using floridapp.RecursoL;


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
            cargar_idioma();

        }
        private void AplicarIdioma()
        {
            label1.Text = RecursoL.Resources.rreuf1;
            label2.Text=Resources.rreuf2;
            label3.Text=Resources.rreuf3;
            label4.Text=Resources.rreuf5;
            label5.Text=Resources.rreuf4;
            button1.Text=Resources.rreuf6;
        }
        private void cargar_idioma()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura.Nombre);
            AplicarIdioma();
        }
        private void refresh()
        {
            


                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    cmbHoras.DataSource = profesor.filtrar_horas_por_dias(dtpDia.Value);
                    conexion.CerrarConexion();
                }

                if (cmbHoras.Items.Count == 0)
                {
                    cmbHoras.Items.Add("No queda horas disponibles.");
                    cmbHoras.SelectedIndex = 0;
                }
            }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpDia.Value < DateTime.Now)
            {
                MessageBox.Show("La reserva tiene que tener un día de aticipación");
            }
            else
            {
                int id_ci = 0;
                DialogResult resultado = MessageBox.Show("Confirma para realizar la reserva.",
                "RESERVA TUTORIA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                {
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        id_ci = profesor.buscar_ciclo();
                        conexion.CerrarConexion();
                    }
                    string nombre = "";
                    string ciclo = "";
                    string gmail = "";
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        nombre = usuario.obtener_nombre_usuario();
                        conexion.CerrarConexion();
                    }
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        ciclo = usuario.obtener_nombre_ciclo();
                        conexion.CerrarConexion();
                    }
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        gmail = profesor.Email_profesor();
                        conexion.CerrarConexion();
                    }
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        try
                        {
                            profesor.realizar_reserva_profesor(dtpDia.Value, cmbHoras.SelectedItem.ToString(), id_ci);
                            MessageBox.Show("Reserva realizado con exito.");
                            string error = "";
                            StringBuilder sb = new StringBuilder();
                            sb.Append(string.Format("{0} del ciclo {1} ha realizado una reserva para una tutoria para la fecha {2} a las {3}", nombre, ciclo, dtpDia.Value.ToString("MM-dd"), cmbHoras.SelectedItem.ToString()));
                            EnviarGmail.EnviarMensaje(sb, gmail, "NOT-REPLY", error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al reservar.");
                        }

                        conexion.CerrarConexion();
                    }
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        try
                        {
                            string error = "";
                            StringBuilder sb = new StringBuilder();
                            sb.Append(string.Format("Has realizado una reserva para una tutoria privada para el dia {0} a las {1} al profesor {2}.", dtpDia.Value.ToString(),cmbHoras.SelectedItem.ToString(),lblprofesor.Text));
                            EnviarGmail.EnviarMensaje(sb, usuario.Email, "NOT-REPLY", error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al reservar.");
                        }

                        conexion.CerrarConexion();
                    }
                }
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
