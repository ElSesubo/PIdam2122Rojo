using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace floridapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelVista.Controls.Clear();
            panelVista.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnReunion_Click(object sender, EventArgs e)
        {

        }

        private void btnCafeteria_Click(object sender, EventArgs e)
        {
            Cafeteria caf = new Cafeteria();
            addUserControl(caf);
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {

        }

        private void btnNews_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
