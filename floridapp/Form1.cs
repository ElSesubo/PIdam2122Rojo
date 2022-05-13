using floridapp.UserControls;
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
            Reunion reu = new Reunion();
            addUserControl(reu);
        }

        private void btnCafeteria_Click(object sender, EventArgs e)
        {
            Cafeteria caf = new Cafeteria();
            addUserControl(caf);
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            Biblio bib = new Biblio();
            addUserControl(bib);
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            News nw = new News();
            addUserControl(nw);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (usuario.Tipo == 2)
            {
                btnListaMod.Hide();
            }
            else
            {
                btnListaMod.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelVista_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
