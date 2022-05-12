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
    public partial class RealizarReunion : UserControl
    {
        public RealizarReunion()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            RealizarReunionFormulario reu = new RealizarReunionFormulario();
            addUserControl(reu);
        }

        private void RealizarReunion_Load(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }
    }
}
