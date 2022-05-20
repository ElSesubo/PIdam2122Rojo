using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace floridapp
{
    class Pedido
    {
        private int id;
        private bool llevar;
        private string nif;
        private TimeSpan hora;
        private bool recogido;
        private bool preparado;
        private int menu;
        private string nombre_menu;
        private double precio;


        //Constructores
        public Pedido(int id, bool llevar, string nif, TimeSpan hora, bool recogido, bool preparado, int menu )
        {
            this.id = id;
            this.llevar = llevar;
            this.hora = hora;
            this.recogido = recogido;
            this.preparado = preparado;
            this.nif = nif;
            this.menu = menu;
        }
        public Pedido(string menu)
        {
            this.nombre_menu = menu;
        }
        public Pedido(int id)
        {
            this.menu = id;
        }
        public Pedido(double precio)
        {
            this.precio = precio;
        }
        public Pedido()
        {

        }
        public int Id { get => id; set => id = value; }
        public bool Llevar { get => llevar; set => llevar = value; }
        public TimeSpan Hora { get => hora; set => hora = value; }
        public bool Recogido { get => recogido; set => recogido = value; }
        public bool Preparado { get => preparado; set => preparado = value; }
        public string Nif { get => nif; set => nif = value; }
        public int Menu { get => menu; set => menu = value; }
        public string Nombre_menu { get => nombre_menu; set => nombre_menu = value; }
        public double Precio { get => precio; set => precio = value; }

        /// <summary>
        /// MÉtodo que inserta registro en la tabla pedidos
        /// </summary>
        /// <param name="reserva"></param>
        /// <param name="menu"></param>
        /// <param name="nif"></param>
        /// <param name="llevar"></param>
        public static void InsertarReserva(TimeSpan reserva, int menu, string nif, int llevar)
        {
            string consulta = "";
            consulta = String.Format("INSERT INTO pedido (hora_pedido, id_menu, nifusu, llevar, recogido, preparado, dia) VALUES " +
                    "('{0}','{1}','{2}','{3}',0,0,'{4}')", reserva, menu, nif,llevar, DateTime.Now.ToString("yyyy-MM-dd"));

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.ExecuteReader();

        }

        /// <summary>
        /// Método que devuelve la lista de pedidos pendientes y no recogidos de hoy
        /// </summary>
        /// <returns></returns>
        public static List<Pedido> ListaMenu()
        {
            List<Pedido> lista = new List<Pedido>();
            string consulta = "";
            consulta = String.Format("SELECT id, llevar, nifusu, hora_pedido, recogido, preparado, id_menu FROM pedido WHERE recogido=0 and dia='{0}';", DateTime.Now.ToString("yyyy-MM-dd"));
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Pedido pedi = new Pedido(reader.GetInt16(0), reader.GetBoolean(1), reader.GetString(2),reader.GetTimeSpan(3),reader.GetBoolean(4),reader.GetBoolean(5),reader.GetInt16(6));
                    lista.Add(pedi);
                }
            }
            reader.Close();
            return lista;
        }


        /// <summary>
        /// Método que actualiza la tabla de pedidos, haciendo que pedido este preparado.
        /// </summary>
        /// <param name="id"></param>
        public static void ActualizarPreparado(int id)
        {
            string consulta2 = "";
            consulta2 = String.Format("UPDATE pedido set preparado=1 where id='{0}';", id);
            MySqlCommand comando2 = new MySqlCommand(consulta2, conexion.Conexion);
            comando2.ExecuteReader();
        }

        /// <summary>
        /// Método que actualiza la tabla de pedidos, haciendo que el pedido este recogido.
        /// </summary>
        /// <param name="id"></param>
        public static void ActualizarRecogido(int id)
        {

                string consulta2 = "";
                consulta2 = String.Format("UPDATE pedido set recogido=1 where id='{0}';", id);
                MySqlCommand comando2 = new MySqlCommand(consulta2, conexion.Conexion);
                comando2.ExecuteReader();
        }

        /// <summary>
        /// Método que devuelve la lista de pedidos filtado por nif
        /// </summary>
        /// <param name="nif"></param>
        /// <returns></returns>
        public static List<Pedido> BuscarMenu(string nif)
        {
            List<Pedido> lista = new List<Pedido>();
            string consulta = "";
            consulta = String.Format("SELECT id, llevar, nifusu, hora_pedido, recogido, preparado, id_menu FROM pedido WHERE nifusu='{0}' AND recogido=0;",nif);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Pedido pedi = new Pedido(reader.GetInt16(0), reader.GetBoolean(1), reader.GetString(2), reader.GetTimeSpan(3), reader.GetBoolean(4), reader.GetBoolean(5), reader.GetInt16(6));
                    lista.Add(pedi);
                }
            }
            reader.Close();
            return lista;
        }

        /// <summary>
        /// Método devuelve una lista con los nombres de los menus.Lo usaremos para cargar posteriolmente el combobox.
        /// </summary>
        /// <returns></returns>
        public static List<Pedido> ListaMenus()
        {
            List<Pedido> lista = new List<Pedido>();
            string consulta = "";
            consulta = String.Format("SELECT nombre_menu FROM menu;");
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Pedido pedi = new Pedido(reader.GetString(0));
                    lista.Add(pedi);
                }
            }
            reader.Close();
            return lista;
        }


        /// <summary>
        /// Método que busca y devulve el precio del menu asignado
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public static double BuscarPrecio(string menu)
        {
            double precio = 0;
            string consulta = "";
            consulta = String.Format("SELECT precio FROM menu WHERE nombre_menu='{0}';", menu);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    precio = reader.GetDouble(0);
                }
            }
            reader.Close();
            return precio;

        }


        /// <summary>
        /// Método que devuelve el id del menu asignado.
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public static int ListarMenus(string menu)
        {
            int id = 0;
            string consulta = "";
            consulta = String.Format("SELECT id FROM menu WHERE nombre_menu='{0}';",menu);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                     id=reader.GetInt16(0);                   
                }
            }
            reader.Close();
            return id;
        }
    }
}
