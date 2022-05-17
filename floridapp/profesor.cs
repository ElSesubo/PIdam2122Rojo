using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace floridapp
{
    internal class profesor
    {
        private usuario user;

        private static string modulo;

        public static string Modulo { get => modulo; set => modulo = value; }


        private static int buscar_ciclo()
        {
            int ciclo;
            string nif = usuario.BuscarNIF(usuario.Email);
            string consulta = string.Format("SELECT cicl from ciclo_pertenece where user_nif='{0}';", nif);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                ciclo = reader.GetInt32(0);
            }
            else
            {
                ciclo = 0;
            }
            
            reader.Close();
            return ciclo;

        }

        

        public static List<string> cargar_profesor_modulos()
        {
            
            int ciclo=buscar_ciclo();
            List<string> ciclos = new List<string>();
            string consulta = string.Format("SELECT u.nombre FROM usuario u INNER JOIN ciclo_pertenece c INNER JOIN modulo_profesor m ON m.nif_user=c.user_nif AND c.user_nif=u.nif WHERE m.modulo = '{0}' AND c.cicl = '{1}'; ", Modulo,ciclo);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                ciclos.Add(reader.GetString(0));
            }
            reader.Close();
            return ciclos;
        }

    }


}
