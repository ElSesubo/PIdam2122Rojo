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
    public partial class listaModulos : UserControl
    {
        public listaModulos()
        {
            InitializeComponent();
        }

        private void listaModulos_Load(object sender, EventArgs e)
        {
            cargar_idioma();
        }
        private void AplicarIdioma()
        {
            label1.Text = Resources.lm1;
            label2.Text = Resources.lm2;
            label3.Text = Resources.lm3;
            btnBuscar.Text = Resources.lm4;
           
        }
        private void cargar_idioma()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura.Nombre);
            AplicarIdioma();
        }
    }
}
