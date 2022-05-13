using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace floridapp
{
    internal class cafeteria
    {
        private int id;
        private int numero_mesa;
        private TimeSpan hora;
        private bool ocupado;
        private usuario user;

        public cafeteria(int id ,int numero_mesa, TimeSpan hora)
        {
            this.id = id;
            this.numero_mesa = numero_mesa;
            this.hora = hora;
        }

        public cafeteria(int numero_mesa, bool ocupado)
        {
            this.numero_mesa = numero_mesa;
            this.ocupado = ocupado;
        }

        public cafeteria (int numero_mesa)
        {
            this.numero_mesa = numero_mesa;
        }
        public cafeteria()
        {

        }

        public int Numero_mesa { get => numero_mesa; set => numero_mesa = value; }
        public TimeSpan Hora { get => hora; set => hora = value; }
        public int Id { get => id; set=>id=value; }
        public bool Ocupado { get=> ocupado; set=>ocupado=value; }

        public static void InsertarReserva(TimeSpan reserva, int mesa, usuario use)
        {
            string consulta = "";
            consulta = String.Format("INSERT INTO reservar_mesa_cafeteria (hora_reserva, num_mesa, id_user) VALUES " +
                    "('{0}','{1}','{2}')", reserva, mesa, use.Nif);
            if (ComprobarReserva(mesa))
            {
                MessageBox.Show("Ya esta reservada");
            }
            else
            {
                ActualizarMesaR(mesa);
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                comando.ExecuteReader();

            }
        }

        public static void EliminarReserva(cafeteria cafe,int mesa)
        {
            string consulta = "";
            consulta = String.Format("DELETE FROM reserva_mesa_cafeteria WHERE id = '{0}'", cafe.Id);
            ActualizarMesaV(mesa);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.ExecuteReader();
        }

        public static List<cafeteria> ListaMesaCocina()
        {
            List<cafeteria> lista = new List<cafeteria>();
            string consulta = "";
            consulta = String.Format("SELECT num, reservado FROM mesa_cafeteria where reservado=1;");
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cafeteria cafe = new cafeteria(reader.GetInt16(0), reader.GetBoolean(1));
                    lista.Add(cafe);
                }
            }
            reader.Close();
            return lista;
        }
        public static bool ComprobarReserva(int mesa)
        {
            string consulta = "";
            consulta = String.Format("SELECT num, reservado FROM mesa_cafeteria;");
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt16(0) == mesa && reader.GetBoolean(1)==true)
                {
                    return true;
                }
            }
            reader.Close();
            return false;
        }

        public static List<cafeteria> ListaReserva(usuario use)
        {
            List<cafeteria> lista = new List<cafeteria>();
            string consulta = "";
             consulta = String.Format("SELECT id, num_mesa, hora_reserva FROM reservar_mesa_cafeteria WHERE id_user = '{0}'",use.Nif);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cafeteria cafe = new cafeteria(reader.GetInt16(0), reader.GetInt16(1),
                        reader.GetTimeSpan(2));
                    lista.Add(cafe);
                }
            }
            return lista;
        }

        public static List<cafeteria> ListaMesa()
        {
            List<cafeteria> lista = new List<cafeteria>();
            string consulta = "";
            consulta = String.Format("SELECT num FROM mesa_cafeteria;");
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cafeteria cafe = new cafeteria(reader.GetInt16(0));
                    lista.Add(cafe);
                }
            }
            return lista;
        }


        public static void ActualizarMesaR(int mesa)
        {
            string consulta2 = "";
            consulta2 = String.Format("UPDATE mesa_cafeteria set num='{0}', reservado=1;", mesa);
            MySqlCommand comando2 = new MySqlCommand(consulta2, conexion.Conexion);
            comando2.ExecuteReader();
        }

        public static void ActualizarMesaV(int mesa)
        {
            string consulta2 = "";
            consulta2 = String.Format("UPDATE mesa_cafeteria set num='{0}', reservado=0;", mesa);
            MySqlCommand comando2 = new MySqlCommand(consulta2, conexion.Conexion);
            comando2.ExecuteReader();
        }
    }
}
