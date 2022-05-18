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

        /// <summary>
        /// Constructor sobrecargado
        /// </summary>
        /// <param name="id">identificador del registro</param>
        /// <param name="dhr">dia y hora del registro</param>
        /// <param name="id_portatil">identificador del portatil</param>
        /// <param name="id_pecera">identificador de la pecera seleccionada</param>
        /// <param name="id_user">identificador del usuario</param>
        /// <param name="dhd">dia y hora de la devolucion o terminacion de la reserva</param>
        public biblioteca(int id, DateTime dhr,int id_portatil, int id_pecera, string id_user, DateTime dhd)
        {
            this.id = id;
            this.dia_hora_reserva = dhr;
            this.id_portatil = id_portatil;
            this.id_pecera = id_pecera;
            this.id_user = id_user;
            this.dia_hora_devolucion = dhd;
        }

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public biblioteca()
        {

        }

        /// <summary>
        /// Busca un registro por el número de la id 
        /// </summary>
        /// <param name="id">identificardor del registro</param>
        /// <returns>Una lista cargada con los registros que tengan el id correspondiente</returns>
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

        /// <summary>
        /// Busca un registro dependiendo de la consulta que le es mandada a la hora de llamar al método
        /// </summary>
        /// <param name="consulta">consulta realizada con anterioridad en otro método</param>
        /// <returns>una lista carga con los registros dependiendo de el contenido de la consulta enviada</returns>
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

        /// <summary>
        /// Obtiene toda la información de un registro con una concreta id
        /// </summary>
        /// <param name="identificacion">identificador del registro</param>
        /// <returns></returns>
        public static biblioteca ObtenerUsuario(int identificacion)
        {
            biblioteca reg = new biblioteca();
            string consulta = string.Format("SELECT * FROM reserva_biblioteca WHERE id={0}", identificacion);
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

        /// <summary>
        /// Elimina un registro de la base de datos con un concreto identificador
        /// </summary>
        /// <param name="identidad">identificador del registro</param>
        /// <returns>1 o 0 para comprobar que la acción se ha realizado</returns>
        public static int EliminaRegistro(int identidad)
        {
            int retorno;
            string consulta = string.Format("DELETE FROM reserva_biblioteca WHERE id={0}", identidad);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
