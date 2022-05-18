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
            List<profesor> p=new List<profesor>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                 p= profesor.tutoriaprivada();
                conexion.CerrarConexion();
            }
            dgvTutoria.Rows.Clear();
            for(int i = 0; i < p.Count; i++)
            {
                dgvTutoria.Rows.Add(p[i].Nif,p[i].Ciclo,p[i].Dia,p[i].Hora);
            }
        }
    }
}
