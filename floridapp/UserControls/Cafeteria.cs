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
using System.Threading;
using System.Globalization;
using floridapp.RecursoL;

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
            cargar_idioma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RealizarPedidoCafeteria caf = new RealizarPedidoCafeteria();
            //MainControl.showControl(caf, panelVista1);
            if (!Form1.Instance.panelV.Controls.ContainsKey("RealizarPedidoCafeteria"))
            {
                RealizarPedidoCafeteria rc = new RealizarPedidoCafeteria();
                rc.Dock = DockStyle.Fill;
                Form1.Instance.panelV.Controls.Add(rc);
            }
            Form1.Instance.panelV.Controls["RealizarPedidoCafeteria"].BringToFront();
        }

        private void panelVista_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void AplicarIdioma()
        {
            lbl1.Text = RecursoL.Resources.caf1;
            lbl2.Text= RecursoL.Resources.caf2;
            label3.Text= RecursoL.Resources.caf3;
            label4.Text= RecursoL.Resources.caf4;
            button1.Text= RecursoL.Resources.caf5;
        }
        private void cargar_idioma()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura.Nombre);
            AplicarIdioma();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
