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
        public RealizarReunionFormulario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RealizarReunionFormulario_Load(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                List<string> ciclos = profesor.cargar_profesor_modulos();
                for (int i = 0; i < ciclos.Count; i++)
                {
                    cmbProfesor.Items.Add(ciclos[i]);
                }
                conexion.CerrarConexion();
            }
        }
    }
}
