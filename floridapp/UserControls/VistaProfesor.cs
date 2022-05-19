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
    public partial class VistaProfesor : UserControl
    {
        public VistaProfesor()
        {
            InitializeComponent();
        }

        private void VistaProfesor_Load(object sender, EventArgs e)
        {
            List<profesor> p = profesores();//Devuelve la lista de tutoria profesor.
            List<string> list_alumnos = nombre();//Devuelve la lista de nombres traducidos por nif
            List<string> list_ciclos = nombre_de_ciclos();//Devuelve la lista de los nombres de los ciclos traducido por id
            dgvTutoria.Rows.Clear();
            for (int i = 0; i < list_alumnos.Count; i++)
            {
                dgvTutoria.Rows.Add(list_alumnos[i], list_ciclos[i], p[i].Dia, p[i].Hora);
            }
            for (int i = 0; i < list_alumnos.Count; i++)
            {
                comboBox1.Items.Add(list_alumnos[i]);
            }
            for (int i = 0; i < list_ciclos.Count; i++)
            {
                comboBox2.Items.Add(list_ciclos[i]);
            }
            for (int i = 0; i < p.Count; i++)
            {
                comboBox3.Items.Add(p[i].Nif_alumno);
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

        }
    }
}
