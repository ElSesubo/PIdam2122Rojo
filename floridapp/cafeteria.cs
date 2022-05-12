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
        private DateTime hora;
        private usuario user;

        public cafeteria(int id ,int numero_mesa, DateTime hora)
        {
            this.id = id;
            this.numero_mesa = numero_mesa;
            this.hora = hora;
        }

        public cafeteria()
        {

        }

        public int Numero_mesa { get => numero_mesa; set => numero_mesa = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public int Id { get => id; set=>id=value; }

        public static void InsertarReserva(DateTime reserva, int mesa, usuario use)
        {
            string consulta = "";
            consulta = String.Format("INSERT INTO reservar_mesa_cafeteria (hora_reserva, num_mesa, id_user) VALUES " +
                    "('{0}','{1}','{2}')", reserva, mesa, use.Correo);
            string consulta2 = "";
            consulta2 = String.Format("UPDATE mesa_cafeteria set num='{0}', reservado=1;", mesa);
            if (ComprobarReserva(reserva, mesa))
            {
                MessageBox.Show("Ya esta reservada");
            }
            else
            {
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                comando.ExecuteReader();
            }
        }

        public static void EliminarReserva(cafeteria cafe)
        {
            string consulta = "";
            consulta = String.Format("DELETE FROM reserva_mesa_cafeteria WHERE id = '{0}'", cafe.Id);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.ExecuteReader();
        }
        public static bool ComprobarReserva(DateTime reservaa, int mesa)
        {
            string consulta = "";
            consulta = String.Format("SELECT hora_reserva, num_mesa FROM reservar_mesa_cafeteria;");
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetDateTime(0) == reservaa && reader.GetInt16(1)==mesa)
                {
                    return true;
                }
            }
            return false;
        }

        public static List<cafeteria> ListaReserva(usuario use)
        {
            List<cafeteria> lista = new List<cafeteria>();
            string consulta = "";
             consulta = String.Format("SELECT id, num_mesa, hora_reserva FROM reservar_mesa_cafeteria WHERE id_user = '{0}'",use.Correo);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cafeteria cafe = new cafeteria(reader.GetInt16(0), reader.GetInt16(1),
                        reader.GetDateTime(2));
                    lista.Add(cafe);
                }
            }
            return lista;
        }
    }
}
