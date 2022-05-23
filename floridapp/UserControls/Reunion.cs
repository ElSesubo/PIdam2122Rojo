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
    public partial class Reunion : UserControl
    {
        public Reunion()
        {
            InitializeComponent();
        }

        private void Reunion_Load(object sender, EventArgs e)
        {
            cargar_idioma();
        }
        private void AplicarIdioma()
        {
            label1.Text = RecursoL.Resources.reu1;
            label2.Text=RecursoL.Resources.reu2;
            label3.Text=RecursoL.Resources.reu3;
            button1.Text=RecursoL.Resources.reu4;
        }
        private void cargar_idioma()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura.Nombre);
            AplicarIdioma();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.panelV.Controls.ContainsKey("RealizarReunion"))
            {
                RealizarReunion ru = new RealizarReunion();
                ru.Dock = DockStyle.Fill;
                Form1.Instance.panelV.Controls.Add(ru);
            }
            Form1.Instance.panelV.Controls["RealizarReunion"].BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
