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
            List<Pedido> pedi = new List<Pedido>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                cafe = cafeteria.ListaMesasDisponibles();
                pedi = Pedido.ListaMenus();
                conexion.CerrarConexion();
            }
            cbMesa.Items.Clear();
            for (int i = 0; i < cafe.Count; i++)
            {
                cbMesa.Items.Add(cafe[i].Numero_mesa);
            }
            
            for (int j = 0; j < pedi.Count; j++)
            {
                comboBox1.Items.Add(pedi[j].Nombre_menu);
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

            int id2 = 0;
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                id2 = Pedido.ListarMenus(comboBox1.Text);
                conexion.CerrarConexion();
            }
            
            bool llevar = checkBox1.Checked;
            int llevar2= 0;
            if (llevar)
            {
                llevar2 = 1;
            }
            else
            {
                llevar2 = 0;
            }

            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                Pedido.InsertarReserva(hora, id2, nif, llevar2);
                conexion.CerrarConexion();
            }
            Cargar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
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
=======
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Pedido.BuscarPrecio(comboBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                textBox1.Text = Pedido.BuscarPrecio(comboBox1.Text).ToString();
                conexion.CerrarConexion();
            }
            
>>>>>>> 9fb43a8f91770989f370329e310afbf57c43f78d
        }
    }
}
