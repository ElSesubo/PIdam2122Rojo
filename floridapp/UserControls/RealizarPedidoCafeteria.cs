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
    public partial class RealizarPedidoCafeteria : UserControl
    {
        public RealizarPedidoCafeteria()
        {
            InitializeComponent();
        }

        private void RealizarPedidoCafeteria_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<cafeteria> cafe = new List<cafeteria>();

            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                cafe = cafeteria.ListaMesa();
                conexion.CerrarConexion();
            }
            
            for (int i = 0; i < cafe.Count; i++)
            {
                comboBox2.Items.Add(cafe[i].Numero_mesa);
            }

        }
    }
}
