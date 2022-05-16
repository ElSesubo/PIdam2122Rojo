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
    internal class biblioteca // Esta clase los valores están mal, son ID, NIF, Aula y Portatil (ambos bool), Aula(numero), hora reserva y si ha sido devuelto
    {
        private int id_portatil;
        private int id_pecera;
        private bool reserva_portatil;
        private bool reserva_pecera;

        public biblioteca(int id_portatil, int id_pecera, bool reserva_portatil, bool reserva_pecera)
        {
            this.id_portatil = id_portatil;
            this.id_pecera = id_pecera;
            this.reserva_portatil = reserva_portatil;
            this.reserva_pecera = reserva_pecera;
        }

        public int Id_portatil { get => id_portatil; set => id_portatil = value; }
        public int Id_pecera { get => id_pecera; set => id_pecera = value; }
        public bool Reserva_portatil { get => reserva_portatil; set => reserva_portatil = value; }
        public bool Reserva_pecera { get => reserva_pecera; set => reserva_pecera = value; }

        public static List<biblioteca> BuscarUsuario(string consulta)
        {
            List<biblioteca> lista = new List<biblioteca>();
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    biblioteca registro = new biblioteca(reader.GetInt32(0), reader.GetInt32(1), reader.GetBoolean(2),
                        reader.GetBoolean(3));
                    lista.Add(registro);
                }
            }
            return lista;
        }

        public static void reservar_portatil()
        {
            string consulta = "INSERT INTO biblioteca";
        }
    }
}
