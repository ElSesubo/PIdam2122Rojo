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

        public static string modulo;

        private string nif;
        
        private List<string> lista_horas = new List<string>() { "08:00:00","08:30:00",   "09:00:00","09:30:00",   "10:00:00","10:30:00" ,   "11:00:00","11:30:00" ,   "12:00:00","12:30:00",   "13:00:00","13:30:00",
           "14:00:00","14:30:00",   "15:00:00","15:30:00",   "16:00:00","16:30:00",   "17:00:00","17:30:00",   "18:00:00","18:30:00",   "19:00:00","19:30:00",   "20:00:00","20:30:00",   "21:00:00","21:30:00",
           "22:00:00","22:30:00",   "23:00:00","23:30:00",   "00:00:00"};
        public string Nif { get => nif; }
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

        

        public string cargar_profesor_modulos()
        {
            
            int ciclo=buscar_ciclo();
            string ciclos ="";
            string consulta = string.Format("SELECT u.nombre,u.apellido,u.nif FROM usuario u INNER JOIN ciclo_pertenece c INNER JOIN modulo_profesor m ON m.nif_user=c.user_nif AND c.user_nif=u.nif WHERE m.modulo = '{0}' AND c.cicl = '{1}'; ", profesor.modulo,ciclo);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                ciclos=reader.GetString(0)+" "+reader.GetString(1);
                this.nif = reader.GetString(2);
            }
            reader.Close();
            return ciclos;
        }

        public void realizar_reserva_profesor(DateTime dia,string hora)
        {
            string nif = usuario.BuscarNIF(usuario.Email);
            string consulta = "INSERT INTO reservar_profesor VALUES(@id,@h_re,@ocu,@id_user,@nif_profe,@dia);";
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("id", null);
            comando.Parameters.AddWithValue("h_re", hora);
            comando.Parameters.AddWithValue("ocu", true);
            comando.Parameters.AddWithValue("id_user", nif);
            comando.Parameters.AddWithValue("nif_profe", this.nif);
            comando.Parameters.AddWithValue("dia", dia.ToString("yyyy/MM/dd"));
            comando.ExecuteNonQuery();

        }

        private List<string> filtrar_horas_por_dias(DateTime dia)
        {
            TimeSpan a;
            List<string> hora_dia=new List<string>();
            string consulta = "SELECT * FROM reservar_profesor WHERE dia_reserva=@dia and nif_profesor=@nif_pro;";
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("dia", dia.ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("nif_pro", this.nif);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                a = reader.GetTimeSpan(1);
                hora_dia.Add(a.ToString());
            }
            reader.Close();
            return hora_dia;
        }

        public List<int> indices(DateTime dia)
        {
            List<int> indices = new List<int>();
            List<string> hora = filtrar_horas_por_dias(dia);
            for(int i = 0; i < hora.Count; i++)
            {
                for(int j = 0; j < lista_horas.Count; j++)
                {
                    if (hora[i] == this.lista_horas[j])
                    {
                        indices.Add(j);
                    }
                }
            }
            return indices;
        }

    }


}
