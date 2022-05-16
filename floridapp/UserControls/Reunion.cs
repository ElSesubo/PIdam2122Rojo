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
    public partial class Reunion : UserControl
    {
        public Reunion()
        {
            InitializeComponent();
        }

        private void Reunion_Load(object sender, EventArgs e)
        {

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
