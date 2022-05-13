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

namespace floridapp
{
    public partial class accesoCocina : Form
    {
        public accesoCocina()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void accesoCocina_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            Thread.Sleep(2000);
>>>>>>> 37ce448a8ea3ff3bee1f8dce08dfac0519bcbe29
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                dtgvUsuarios.DataSource = cafeteria.ListaMesaCocina();
                conexion.CerrarConexion();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
