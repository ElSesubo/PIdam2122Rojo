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
    public partial class News : UserControl
    {
        public News()
        {
            InitializeComponent();
        }

        private void News_Load(object sender, EventArgs e)
        {
            cargar_idioma();
        }

        private void AplicarIdioma()
        {
            label1.Text = RecursoL.Resources.new1;
            button1.Text = RecursoL.Resources.new3;
        }
        private void cargar_idioma()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura.Nombre);
            AplicarIdioma();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
