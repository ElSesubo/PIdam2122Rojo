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

namespace floridapp
{
    public partial class accesoCocina : Form
    {
        public accesoCocina()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void accesoCocina_Load(object sender, EventArgs e)
        {

            Cargar();
            Cargar2();

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvPedidos.SelectedRows.Count == 1)
            {
                int cafe = (Convert.ToInt32(dtgvPedidos.CurrentRow.Cells[0].Value));
                                        
                

                DialogResult confirmacion = MessageBox.Show("Vaciar la mesa el registro seleccionado. ¿Continuar?",
                                                    "Eliminación", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        cafeteria.ActualizarMesaV(cafe);
                        conexion.CerrarConexion();
                    }
                    Cargar();
                }
            }
        }
        private void Cargar()
        {
            List<cafeteria> cafe = new List<cafeteria>();

            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                cafe = cafeteria.ListaMesaCocina();
                conexion.CerrarConexion();
            }
            dtgvPedidos.Rows.Clear();
            for (int i = 0; i < cafe.Count; i++)
            {
                dtgvPedidos.Rows.Add(cafe[i].Numero_mesa, cafe[i].Ocupado);
            }
        }
        private void Cargar2()
        {
            List<Pedido> pedi = new List<Pedido>();

            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                pedi = Pedido.ListaMenu();
                conexion.CerrarConexion();
            }
            dgvPedidoMenu.Rows.Clear();
            for (int i = 0; i < pedi.Count; i++)
            {
                dgvPedidoMenu.Rows.Add(pedi[i].Id, pedi[i].Llevar, pedi[i].Nif, pedi[i].Hora, pedi[i].Recogido, pedi[i].Preparado, pedi[i].Menu);
            }
        }
        private void dtgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPedidoMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPreparado_Click(object sender, EventArgs e)
        {
            if (dgvPedidoMenu.SelectedRows.Count == 1)
            {
                int id = (Convert.ToInt32(dgvPedidoMenu.CurrentRow.Cells[0].Value));



                DialogResult confirmacion = MessageBox.Show("Menu preparado en el registro seleccionado. ¿Continuar?",
                                                    "Eliminación", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        Pedido.ActualizarPreparado(id);
                        conexion.CerrarConexion();
                    }
                    Cargar2();
                }
            }
        }

        private void btnEliminarMenu_Click(object sender, EventArgs e)
        {
            if (dgvPedidoMenu.SelectedRows.Count == 1)
            {
                int id = (Convert.ToInt32(dgvPedidoMenu.CurrentRow.Cells[0].Value));
                bool preparado = (Convert.ToBoolean(dgvPedidoMenu.CurrentRow.Cells[5].Value));

                if (preparado == true)
                {
                    DialogResult confirmacion = MessageBox.Show("Menu recogido en el registro seleccionado. ¿Continuar?",
                                    "Eliminación", MessageBoxButtons.YesNo);

                    if (confirmacion == DialogResult.Yes)
                    {
                        if (conexion.Conexion != null)
                        {
                            conexion.AbrirConexion();
                            Pedido.ActualizarRecogido(id);
                            conexion.CerrarConexion();
                        }
                        Cargar2();
                    }
                }
                else
                {
                    MessageBox.Show("Aun no esta preparado");
                }


            }
        }

        private void btnBuscarMenu_Click(object sender, EventArgs e)
        {
            List<Pedido> pedi2 = new List<Pedido>();
            string nif = "";
            nif = txtBuscarMenu.Text;
            
            for(int i = 0; i < dgvPedidoMenu.Rows.Count; i++)
            {
                if (nif ==Convert.ToString(dgvPedidoMenu.Rows[i].Cells[2].Value))
                {
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        pedi2=Pedido.BuscarMenu(nif);
                        conexion.CerrarConexion();
  
                    }
                    dgvPedidoMenu.Rows.Clear();
                    for (int j = 0; j < pedi2.Count; j++)
                    {
                        dgvPedidoMenu.Rows.Add(pedi2[j].Id, pedi2[j].Llevar, pedi2[j].Nif, pedi2[j].Hora, pedi2[j].Recogido, pedi2[j].Preparado, pedi2[j].Menu);
                    }
                }
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Cargar2();
        }
    }
}
