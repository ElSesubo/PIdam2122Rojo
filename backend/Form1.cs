using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ProyectoIntegrado

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.CerrarConexion();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
