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
using System.Globalization;
using System.Threading;

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
            if (usuario.Tipo == 2)
            {
                panelVista.Controls.Clear();
                Reunion reu = new Reunion();
                //MainControl.showControl(reu, panelVista);
                _instance = this;
                reu.Dock = DockStyle.Fill;
                panelVista.Controls.Add(reu);
                reu.BringToFront();
            }
            else
            {
                panelVista.Controls.Clear();
                VistaProfesor vip = new VistaProfesor();
                //MainControl.showControl(reu, panelVista);
                _instance = this;
                vip.Dock = DockStyle.Fill;
                panelVista.Controls.Add(vip);
                vip.BringToFront();
            }
            
        }

        private void btnCafeteria_Click(object sender, EventArgs e)
        {
            panelVista.Controls.Clear();
            Cafeteria caf = new Cafeteria();
            //MainControl.showControl(caf, panelVista);
            _instance = this;
            caf.Dock = DockStyle.Fill;
            panelVista.Controls.Add(caf);
            caf.BringToFront();
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            panelVista.Controls.Clear();
            _instance = this;
            Biblio bib = new Biblio();
            //addUserControl(bib);
            bib.Dock = DockStyle.Fill;
            panelVista.Controls.Add(bib);
            bib.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelVista.Controls.Clear();
            News nw = new News();
            //addUserControl(nw);
            _instance = this;
            nw.Dock = DockStyle.Fill;
            panelVista.Controls.Add(nw);
            nw.BringToFront();

            if (usuario.Tipo == 2)
            {
                pbUsuario.Hide();
                btnListaMod.Hide();
            }
            else
            {
                pbUsuario.Show();
                pbAlumno.Hide();
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

        private void btnListaMod_Click(object sender, EventArgs e)
        {
            panelVista.Controls.Clear();
            _instance = this;
            listaModulos lmod = new listaModulos();
            //addUserControl(bib);
            lmod.Dock = DockStyle.Fill;
            panelVista.Controls.Add(lmod);
            lmod.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelVista.Controls.Clear();
            News nw = new News();
            //addUserControl(nw);
            _instance = this;
            nw.Dock = DockStyle.Fill;
            panelVista.Controls.Add(nw);
            nw.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cultura = "";
            switch (cbLenguas.Text)
            {
                case "Castellano":
                    {
                        cultura = "ES-ES";
                        break;
                    }
                case "Inglés":
                    {
                        cultura = "EN-GB";  
                        break;
                    }
            }
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();
        }
    }
}
