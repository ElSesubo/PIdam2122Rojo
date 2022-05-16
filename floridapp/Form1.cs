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
        public static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;
            }
        }
        public Panel panelV
        {
            get { return panelVista; }
            set { panelVista = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        //private void addUserControl(UserControl userControl)
        //{
        //    userControl.Dock = DockStyle.Fill;
        //    panelVista.Controls.Clear();
        //    panelVista.Controls.Add(userControl);
        //    userControl.BringToFront();
        //}

        private void btnReunion_Click(object sender, EventArgs e)
        {
            Reunion reu = new Reunion();
            //MainControl.showControl(reu, panelVista);
            _instance = this;
            reu.Dock = DockStyle.Fill;
            panelVista.Controls.Add(reu);
            reu.BringToFront();
        }

        private void btnCafeteria_Click(object sender, EventArgs e)
        {

            Cafeteria caf = new Cafeteria();
            //MainControl.showControl(caf, panelVista);
            _instance = this;
            caf.Dock = DockStyle.Fill;
            panelVista.Controls.Add(caf);
            caf.BringToFront();
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            _instance = this;
            Biblio bib = new Biblio();
            //addUserControl(bib);
            bib.Dock = DockStyle.Fill;
            panelVista.Controls.Add(bib);
            bib.BringToFront();
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            News nw = new News();
            //addUserControl(nw);
            _instance = this;
            nw.Dock = DockStyle.Fill;
            panelVista.Controls.Add(nw);
            nw.BringToFront();
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
