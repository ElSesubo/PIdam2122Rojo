using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using floridapp.UserControls;

namespace floridapp
{
    public partial class Cafeteria : UserControl
    {
        public Cafeteria()
        {
            InitializeComponent();
        }

        private void Cafeteria_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RealizarPedidoCafeteria caf = new RealizarPedidoCafeteria();
            MainControl.showControl(caf, panelVista1);
        }

        private void panelVista_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
