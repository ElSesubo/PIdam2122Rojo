using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace floridapp
{
    internal class profesor: usuario
    {

        public static string modulo;

        private string nif;

        private List<string> lista_horas = new List<string>() { "08:00:00","08:30:00",   "09:00:00","09:30:00",   "10:00:00","10:30:00" ,   "11:00:00","11:30:00" ,   "12:00:00","12:30:00",   "13:00:00","13:30:00",
           "14:00:00","14:30:00",   "15:00:00","15:30:00",   "16:00:00","16:30:00",   "17:00:00","17:30:00",   "18:00:00","18:30:00",   "19:00:00","19:30:00",   "20:00:00","20:30:00",   "21:00:00","21:30:00",
           "22:00:00","22:30:00",   "23:00:00","23:30:00",   "00:00:00"};
        public string Nif1 { get => nif; }
        public List<string> Lista_horas { get => lista_horas; set => lista_horas = value; }

        private int buscar_ciclo()
        {
            int ciclo=0;
            string nif = usuario.BuscarNIF(usuario.Email);
            string consulta = string.Format("SELECT cicl from ciclo_pertenece where user_nif='{0}';", nif);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                ciclo = reader.GetInt32(0);
            }           
            reader.Close();
            return ciclo;

        }

        

        public List<string> cargar_profesor_modulos()
        {
            
            int ciclo=buscar_ciclo();
            List<string> ciclos = new List<string>();
            string consulta = string.Format("SELECT u.nombre,u.apellido,u.nif FROM usuario u INNER JOIN ciclo_pertenece c INNER JOIN modulo_profesor m ON m.nif_user=c.user_nif AND c.user_nif=u.nif WHERE m.modulo = '{0}' AND c.cicl = '{1}'; ", profesor.modulo,ciclo);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                ciclos.Add(reader.GetString(0)+" "+reader.GetString(1));
                this.nif = reader.GetString(2);
            }
            reader.Close();
            return ciclos;
        }

        public void realizar_reserva_profesor(DateTime dia,DateTime hora)
        {
            string consulta = string.Format("INSERT INTO ");
        }


    }


}
