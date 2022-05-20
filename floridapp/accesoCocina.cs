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
        int idmenu=0;
        public accesoCocina()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void accesoCocina_Load(object sender, EventArgs e)
        {
            refresh();
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
        private void refresh()
        {
            Cargar();
            Cargar2();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            idmenu = int.Parse(dgvMenu.Rows[fila].Cells[0].Value.ToString());
            txtMenu.Text=dgvMenu.Rows[fila].Cells[1].Value.ToString();
            nudPrecio.Value=decimal.Parse(dgvMenu.Rows[fila].Cells[2].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            cargar_dgvmenu();
        }

        /// <summary>
        /// Este metodo refresca la datagridview del menu.
        /// </summary>
        private void cargar_dgvmenu()
        {
            dgvMenu.Rows.Clear();
            List<Pedido> menus=new List<Pedido>();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                menus = Pedido.lista_menus();
                conexion.CerrarConexion();
            }
            for(int i = 0; i < menus.Count; i++)
            {
                dgvMenu.Rows.Add(menus[i].Menu,menus[i].Nombre_menu,menus[i].Precio);
            }

        }
 
        private void limpiar()
        {
            txtMenu.Text = "";
            nudPrecio.Value = 0;
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            refresh();
        }


        /// <summary>
        /// Este boton modifica los datos del menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                try
                {
                    result = Pedido.modificarmenu(idmenu, txtMenu.Text, double.Parse(nudPrecio.Value.ToString()));
                    if(result != 0)
                    {
                        MessageBox.Show("Se ha modificado con exito");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                conexion.CerrarConexion();
            }
            cargar_dgvmenu();
            limpiar();
        }


        private bool comprobarSIexiste()
        {
            bool existe = true;
            for(int i = 0; i < dgvMenu.Rows.Count; i++)
            {
                if (txtMenu.Text != dgvMenu.Rows[i].Cells[1].Value.ToString())
                {
                    return true;
                }
            }
            return existe;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            
                if (txtMenu.Text != "")
                {
                if (!comprobarSIexiste())
                {
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        try
                        {
                            result = Pedido.insertarMenus(txtMenu.Text, double.Parse(nudPrecio.Value.ToString()));
                            if (result != 0)
                            {
                                MessageBox.Show("Se ha insertado con exito");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        conexion.CerrarConexion();
                    }
                }
                else
                {
                    MessageBox.Show("Ese menu ya existe.");
                }

            }
            else
            {
                MessageBox.Show("El campo de nombre del menu esta vacio.");
            }
            cargar_dgvmenu();
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                try
                {
                    result = Pedido.eliminarMenu(idmenu);
                    if (result != 0)
                    {
                        MessageBox.Show("Se ha eliminado con exito");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                conexion.CerrarConexion();
            }
            cargar_dgvmenu();
            limpiar();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Muestra editar mesas y oculta editar menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditarMesas_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            nummesas();
        }

        /// <summary>
        /// Muestra el numero de mesas totales
        /// </summary>
        private void nummesas()
        {
            int total = 0;
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                total = cafeteria.num_totales_mesa();
                conexion.CerrarConexion();
            }
            lblnum.Text = total.ToString();
        }

        private void lblnum_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            refresh();
        }
        /// <summary>
        /// Elimina una mesa que no esta reservado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                cafeteria.eliminarmesas();
                conexion.CerrarConexion();
            }
            nummesas();
        }

        /// <summary>
        /// Agrega una mesa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnagregarmesa_Click(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                cafeteria.agregarmesas();
                conexion.CerrarConexion();
            }
            nummesas();
        }
    }
}
