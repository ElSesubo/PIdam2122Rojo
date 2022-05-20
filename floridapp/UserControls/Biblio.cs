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
using System.Globalization;
using floridapp.RecursoL;


namespace floridapp.UserControls
{
    public partial class Biblio : UserControl
    {

        public Biblio()
        {
            InitializeComponent();
        }

        private void Biblioteca_Load(object sender, EventArgs e)
        {
            cargar_idioma();
        }
        private void AplicarIdioma()
        {
            label1.Text = Resources.bib1;
            label2.Text = Resources.bib2;
            label3.Text = Resources.bib3;
            button1.Text= Resources.bib4;
        }
        private void cargar_idioma()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura.Nombre);
            AplicarIdioma();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (!Form1.Instance.panelV.Controls.ContainsKey("RealizarReservaBiblioteca"))
            {
                RealizarReservaBiblioteca rb = new RealizarReservaBiblioteca();
                rb.Dock = DockStyle.Fill;
                Form1.Instance.panelV.Controls.Add(rb);
            }
            Form1.Instance.panelV.Controls["RealizarReservaBiblioteca"].BringToFront();

        }

    }
}
