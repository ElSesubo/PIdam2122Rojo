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
    public partial class VistaProfesor : UserControl
    {
        public VistaProfesor()
        {
            InitializeComponent();
        }

        private void VistaProfesor_Load(object sender, EventArgs e)
        {
            refresh();
            cargar_idioma();
        }

        private void AplicarIdioma()
        {
            label1.Text = Resources.vpr1;
        }
        private void cargar_idioma()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura.Nombre);
            AplicarIdioma();
        }
        private void refresh()
        {
            List<profesor> p = profesores();//Devuelve la lista de tutoria profesor.
            List<string> list_alumnos = nombre();//Devuelve la lista de nombres traducidos por nif
            List<string> list_ciclos = nombre_de_ciclos();//Devuelve la lista de los nombres de los ciclos traducido por id
            dgvTutoria.Rows.Clear();
            for (int i = 0; i < list_alumnos.Count; i++)
            {
                dgvTutoria.Rows.Add(list_alumnos[i], p[i].Nif_alumno, list_ciclos[i], p[i].Dia, p[i].Hora, "Anular");
            }
            for(int j=0; j < list_ciclos.Count; j++)
            {
                if (dgvTutoria.Rows[j].Cells[4].Value.ToString() == "04:00:00")
                {
                    dgvTutoria.Rows[j].Visible = false;
                    
                }
            }
        }
        private List<profesor> profesores()
        {
            string nif = "";
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                nif = usuario.BuscarNIF(usuario.Email);
                conexion.CerrarConexion();
            }
            List<profesor> p = new List<profesor>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                p = profesor.tutoriaprivada(nif);
                conexion.CerrarConexion();
            }
            return p;
        }
        private List<string> nombre()
        {
            List<profesor> p=profesores();
            List<string> list_nif = new List<string>();
            for (int j = 0; j < p.Count; j++)
            {
                list_nif.Add(p[j].Nif_alumno);
            }
            List<string> nombres=new List<string>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                nombres = profesor.traducir_nombre(list_nif);
                conexion.CerrarConexion();
            }
            return nombres;
        }

        private List<string> nombre_de_ciclos()
        {
            List<profesor> p = profesores();
            List<int> list_ciclos = new List<int>();
            for (int j = 0; j < p.Count; j++)
            {
                list_ciclos.Add(p[j].Ciclo);
            }
            List<string> nombres = new List<string>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                nombres = profesor.traducir_ciclos(list_ciclos);
                conexion.CerrarConexion();
            }
            return nombres;
        }

        private void dgvTutoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            int fila=e.RowIndex;
            int exito = 0;
            string nombre = "";
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                nombre = usuario.obtener_nombre_usuario();
                conexion.CerrarConexion();
            }
            string modulo = "";
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                modulo = profesor.Modulo_profesor();
                conexion.CerrarConexion();
            }
            string gmail = "";
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                gmail = profesor.Email_alumno(dgvTutoria.Rows[fila].Cells[1].Value.ToString());
                conexion.CerrarConexion();
            }
            string error = "";
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("El profesor {0} del {1} ha anulado tu tutoria.", nombre, modulo));
            EnviarGmail.EnviarMensaje(sb, gmail, "NOT-REPLY",error);
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult resultado = MessageBox.Show("¿Deseas anular la tutoria?",
               "ANULAR!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                {
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        try
                        {
                            exito = profesor.anular_tutoria(dgvTutoria.Rows[fila].Cells[1].Value.ToString(), DateTime.Parse(dgvTutoria.Rows[fila].Cells[4].Value.ToString()), DateTime.Parse(dgvTutoria.Rows[fila].Cells[3].Value.ToString()));
                            if (exito != 0)
                            {
                                MessageBox.Show("Anulado con exito.");
                            }
                            else
                            {
                                MessageBox.Show("Fallo");
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        conexion.CerrarConexion();
                    }
                }

            }
            refresh();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
