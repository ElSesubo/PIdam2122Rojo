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
    class portatil
    {
        private int id;
        private bool reservado;
        private bool devuelto;

        public int Id { get => id; set => id = value; }
        public bool Reservado { get => reservado; set => reservado = value; }
        public bool Devuelto { get => devuelto; set => devuelto = value; }

        public portatil(int id, bool reservado, bool devuelto)
        {
            this.Id = id;
            this.Reservado = reservado;
            this.Devuelto = devuelto;
        }

        /// <summary>
        /// Crea una lista de portatiles
        /// </summary>
        /// <returns>retorna una lista de menus</returns>
        public static List<portatil> ListaPortatiles()
        {
            List<portatil> lista = new List<portatil>();
            string consulta = "";
            consulta = String.Format("SELECT * FROM portatil");
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    portatil port = new portatil(reader.GetInt16(0), reader.GetBoolean(1), reader.GetBoolean(2));
                    lista.Add(port);
                }
            }
            reader.Close();
            return lista;
        }

        /// <summary>
        /// Agrega un portatil
        /// </summary>
        public static void AgregarPortatil()
        {
            string consulta = "";

            consulta = String.Format("INSERT INTO portatil (reservado, devuelto) VALUES (0, 0)");

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.ExecuteReader();
        }
    }
}
