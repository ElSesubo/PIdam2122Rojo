using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace floridapp
{
    internal class biblioteca 
    {
        private int id;
        private DateTime dia_hora_reserva;
        private int id_portatil;
        private int id_pecera;
        private string id_user;
        private DateTime dia_hora_devolucion;

        public int Id { get => id; set => id = value; }
        public DateTime Dia_hora_reserva { get => dia_hora_reserva; set => dia_hora_reserva = value; }
        public int Id_portatil { get => id_portatil; set => id_portatil = value; }
        public int Id_pecera { get => id_pecera; set => id_pecera = value; }
        public string Id_user { get => id_user; set => id_user = value; }
        public DateTime Dia_hora_devolucion { get => dia_hora_devolucion; set => dia_hora_devolucion = value; }

        public biblioteca(int id, DateTime dhr,int id_portatil, int id_pecera, string id_user, DateTime dhd)
        {
            this.id = id;
            this.dia_hora_reserva = dhr;
            this.id_portatil = id_portatil;
            this.id_pecera = id_pecera;
            this.id_user = id_user;
            this.dia_hora_devolucion = dhd;
        }

        public biblioteca()
        {

        }


        public static List<biblioteca> BuscarRegistroId(int id)
        {
            List<biblioteca> lista = new List<biblioteca>();
            string consulta = String.Format("SELECT * FROM reserva_biblioteca WHERE id='{0}'", id);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    biblioteca registro = new biblioteca(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2),
                        reader.GetInt32(3), reader.GetString(4), reader.GetDateTime(5));
                    lista.Add(registro);
                }
            }
            return lista;
        }

        public static List<biblioteca> BuscarRegistro(string consulta)
        {
            List<biblioteca> lista = new List<biblioteca>();
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    biblioteca registro = new biblioteca(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2),
                        reader.GetInt32(3), reader.GetString(4), reader.GetDateTime(5));
                    lista.Add(registro);
                }
            }
            return lista;
        }

        public static List<biblioteca> BuscarReserva(string consulta)
        {
            List<biblioteca> lista = new List<biblioteca>();
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    biblioteca registro = new biblioteca(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2),
                        reader.GetInt32(3), reader.GetString(4), reader.GetDateTime(5));
                    lista.Add(registro);
                }
            }
            return lista;
        }

        public static biblioteca ObtenerUsuario(int identificacion)
        {
            biblioteca reg = new biblioteca();
            string consulta = string.Format("SELECT * FROM usuarios WHERE id={0}", identificacion);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                reg.Id = reader.GetInt16(0);
                reg.Dia_hora_reserva = reader.GetDateTime(1);
                reg.Id_portatil = reader.GetInt32(2);
                reg.Id_pecera = reader.GetInt32(3);
                reg.Id_user = reader.GetString(4);
                reg.Dia_hora_devolucion = reader.GetDateTime(5);
            }
            return reg;
        }

        public static int EliminaRegistro(int identidad)
        {
            int retorno;
            string consulta = string.Format("DELETE FROM reserva_biblioteca WHERE id={0}", identidad);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static void reservar_portatil()
        {
            string consulta = "INSERT INTO biblioteca";

        }
    }
}
