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
            List<cafeteria> cafe = new List<cafeteria>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                cafe = cafeteria.ListaMesaCocina();
                conexion.CerrarConexion();
            }
            dtgvUsuarios.Rows.Clear();
            for(int i = 0; i < cafe.Count; i++)
            {
                dtgvUsuarios.Rows.Add(cafe[i].Numero_mesa, cafe[i].Ocupado);
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
