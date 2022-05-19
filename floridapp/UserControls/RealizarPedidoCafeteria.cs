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
            cbMenu.Items.Clear();
            for (int j = 0; j < pedi.Count; j++)
            {
                cbMenu.Items.Add(pedi[j].Nombre_menu);
            }
            cbMenu.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            DialogResult resultado = MessageBox.Show("¿Enviar pedido?", "informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    
                    TimeSpan hora = TimeSpan.Parse(dateTimePicker1.Value.ToString("T"));
                    string nif = "";
                    
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        nif = usuario.BuscarNIF(usuario.Email);
                        conexion.CerrarConexion();
                    }
                    if (cbMesa.SelectedItem != null)
                    {
                    id = int.Parse(cbMesa.Text);
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
                    }


                    int id2 = 0;


                    bool llevar = cbLlevar.Checked;
                    int llevar2 = 0;
                double precio = double.Parse(txtPrecio.Text);
                    if (llevar)
                    {
                        llevar2 = 1;
                    }
                    else
                    {
                        llevar2 = 0;
                    }
                    if (cbMenu.SelectedItem != null)
                    {
                        if (conexion.Conexion != null)
                        {
                            conexion.AbrirConexion();
                            id2 = Pedido.ListarMenus(cbMenu.Text);
                            conexion.CerrarConexion();
                        }
                        if (conexion.Conexion != null)
                        {
                            conexion.AbrirConexion();
                            Pedido.InsertarReserva(hora, id2, nif, llevar2);
                            conexion.CerrarConexion();
                        }
                    }


                    
                    
                

                StringBuilder mensaje = new StringBuilder();
                StringBuilder mensaje2 = new StringBuilder();

                string user = usuario.Email;
                string err = "No se que paso wey";
                mensaje.Append(String.Format("EL menu selecionado es {0}, su precio es {1} y la mesa es {2} para la hora {3} ", cbMenu.Text,txtPrecio.Text,cbMesa.Text, hora));
                mensaje2.Append(String.Format("La mesa {0} ha sido reservada por {1} para la hora {2}  ", cbMesa.Text, nif,hora));
                EnviarGmail.EnviarMensaje(mensaje, user, "Floridapp, Cafeteria", err);
                MessageBox.Show("Pedido realizado");
                if (cbMesa.SelectedItem != null)
                {
                    EnviarGmail.EnviarMensaje(mensaje2, "aabb@floridauniversitaria.es", "Pedido Mesa", err);
                }
                Cargar();

            }

        }

            

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void cbLlevar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLlevar.Checked == true)
            {
                cbMesa.Enabled = false;
            }
            else
            {
                cbMesa.Enabled = true;
            }

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            Pedido.BuscarPrecio(cbMenu.Text);
        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                txtPrecio.Text = Pedido.BuscarPrecio(cbMenu.Text).ToString();
                conexion.CerrarConexion();
            }
        }

        private void btnLimpiarPedido_Click(object sender, EventArgs e)
        {
            cbLlevar.Checked = false;
            cbMenu.SelectedItem = null;
            cbMesa.SelectedItem = null;
            
        }
    }


    }
