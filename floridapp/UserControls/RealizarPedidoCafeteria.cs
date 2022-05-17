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
    public partial class RealizarPedidoCafeteria : UserControl
    {
        public RealizarPedidoCafeteria()
        {
            InitializeComponent();
        }

        private void RealizarPedidoCafeteria_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cargar()
        {
            List<cafeteria> cafe = new List<cafeteria>();

            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                cafe = cafeteria.ListaMesa();
                conexion.CerrarConexion();
            }
            cbMesa.Items.Clear();
            for (int i = 0; i < cafe.Count; i++)
            {
                cbMesa.Items.Add(cafe[i].Numero_mesa);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cbMesa.Text);
            TimeSpan hora =TimeSpan.Parse(dateTimePicker1.Value.ToString("T"));
            usuario user = new usuario();
            string nif="";
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                 nif = usuario.BuscarNIF(usuario.Email);
                conexion.CerrarConexion();
            }
           
            cafeteria cafes = new cafeteria();
            
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                cafeteria.InsertarReserva(hora, id, nif);
                conexion.CerrarConexion();
            }
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                cafeteria.ActualizarMesaR(int.Parse(cbMesa.SelectedItem.ToString()));
                conexion.CerrarConexion();
            }
            Cargar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbLlevar.Checked == true)
            {
                cbMesa.Enabled = false;
            }
            else
            {
                cbMesa.Enabled = true;
            }
        }
    }
}
