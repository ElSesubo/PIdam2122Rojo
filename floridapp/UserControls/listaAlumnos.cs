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
    public partial class listaAlumnos : UserControl
    {
        public listaAlumnos()
        {
            InitializeComponent();
        }

        private void listaAlumnos_Load(object sender, EventArgs e)
        {
            cargar_idioma();

        }
        private void AplicarIdioma()
        {
            label1.Text = Resources.la1;
            label2.Text = Resources.la2;
            label3.Text = Resources.la3;
            btnBuscar.Text = Resources.la4;

        }
        private void cargar_idioma()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura.Nombre);
            AplicarIdioma();
        }
    }
}
