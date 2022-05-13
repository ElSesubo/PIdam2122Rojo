using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
