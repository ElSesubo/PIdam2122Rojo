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
        private string menu;

        public Pedido(int id, bool llevar, string nif, TimeSpan hora, bool recogido, bool preparado, string menu )
        {
            this.id = id;
            this.llevar = llevar;
            this.hora = hora;
            this.recogido = recogido;
            this.preparado = preparado;
            this.nif = nif;
            this.menu = menu;
        }

        public int Id { get => id; set => id = value; }
        public bool Llevar { get => llevar; set => llevar = value; }
        public TimeSpan Hora { get => hora; set => hora = value; }
        public bool Recogido { get => recogido; set => recogido = value; }
        public bool Preparado { get => preparado; set => preparado = value; }
        public string Nif { get => nif; set => nif = value; }
        public string Menu { get => menu; set => menu = value; }

        public static void InsertarReserva(TimeSpan reserva, string menu, string nif, bool llevar)
        {
            string consulta = "";
            consulta = String.Format("INSERT INTO pedido (hora_pedido, menu, nifusu, llevar, recogido, preparado) VALUES " +
                    "('{0}','{1}','{2}','{3}',0,0)", reserva, menu, nif,llevar);

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.ExecuteReader();

        }
        public static List<Pedido> ListaMenu()
        {
            List<Pedido> lista = new List<Pedido>();
            string consulta = "";
            consulta = String.Format("SELECT id, llevar, nifusu, hora_pedido, recogido, preparado, menu FROM pedido WHERE recogido=0;");
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Pedido pedi = new Pedido(reader.GetInt16(0), reader.GetBoolean(1), reader.GetString(2),reader.GetTimeSpan(3),reader.GetBoolean(4),reader.GetBoolean(5),reader.GetString(6));
                    lista.Add(pedi);
                }
            }
            reader.Close();
            return lista;
        }

        public static void ActualizarPreparado(int id)
        {
            string consulta2 = "";
            consulta2 = String.Format("UPDATE pedido set preparado=1 where id='{0}';", id);
            MySqlCommand comando2 = new MySqlCommand(consulta2, conexion.Conexion);
            comando2.ExecuteReader();
        }

        public static void ActualizarRecogido(int id)
        {

                string consulta2 = "";
                consulta2 = String.Format("UPDATE pedido set recogido=1 where id='{0}';", id);
                MySqlCommand comando2 = new MySqlCommand(consulta2, conexion.Conexion);
                comando2.ExecuteReader();

 
        }
        public static List<Pedido> BuscarMenu(string nif)
        {
            List<Pedido> lista = new List<Pedido>();
            string consulta = "";
            consulta = String.Format("SELECT id, llevar, nifusu, hora_pedido, recogido, preparado, menu FROM pedido WHERE nifusu='{0}' AND recogido=0;",nif);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Pedido pedi = new Pedido(reader.GetInt16(0), reader.GetBoolean(1), reader.GetString(2), reader.GetTimeSpan(3), reader.GetBoolean(4), reader.GetBoolean(5), reader.GetString(6));
                    lista.Add(pedi);
                }
            }
            reader.Close();
            return lista;
        }

    }
}
