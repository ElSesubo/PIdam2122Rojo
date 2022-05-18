﻿using System;
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
        private TimeSpan hora;
        private DateTime dia;
        private string nif_alumno;
        private int ciclo;
        private List<string> lista_horas = new List<string>() { "08:00:00","08:30:00",   "09:00:00","09:30:00",   "10:00:00","10:30:00" ,   "11:00:00","11:30:00" ,   "12:00:00","12:30:00",   "13:00:00","13:30:00",
           "14:00:00","14:30:00",   "15:00:00","15:30:00",   "16:00:00","16:30:00",   "17:00:00","17:30:00",   "18:00:00","18:30:00",   "19:00:00","19:30:00",   "20:00:00","20:30:00",   "21:00:00","21:30:00",
           "22:00:00","22:30:00",   "23:00:00","23:30:00",   "00:00:00"};


        //Constructor para almacenar la informacion de tutoria privadas y cargarlas en una data grid view
        public profesor( TimeSpan hora, DateTime dia, string nif_alumno)
        {
            this.hora = hora;
            this.dia = dia;
            this.nif_alumno = nif_alumno;
        }

        public profesor()
        {

        }

        public string Nif { get => nif; }
        public List<string> Lista_horas { get => lista_horas; }
        public TimeSpan Hora { get => hora; }
        public DateTime Dia { get => dia; }
        public string Nif_alumno { get => nif_alumno; }
        public int Ciclo { get => ciclo; }


        /// <summary>
        /// Metodo que busca el ciclo del alumno
        /// </summary>
        /// <returns>Devuelve el ciclo que esta matriculado el alumno</returns>
        private int buscar_ciclo()
        {
            int ciclo=0;
            string nif = usuario.BuscarNIF(usuario.Email);
            string consulta = string.Format("SELECT cicl from ciclo_pertenece where user_nif='{0}';", nif);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())//El if no me funcionaba asi que use el while, no es optimo pero funciona.
            {
                ciclo = reader.GetInt32(0);
            }           
            reader.Close();
            return ciclo;
        }

        /// <summary>
        /// Sobrecarga de la funcion anterior que busca el ciclo con el nif pasado por parametro.
        /// </summary>
        /// <param name="nif_a"></param>
        /// <returns></returns>
        private int buscar_ciclo(string nif_a)
        {
            int id_ciclo = 0;
            string consulta = string.Format("SELECT cicl from ciclo_pertenece where user_nif='{0}';", nif_a);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())//El if no me funcionaba asi que use el while, no es optimo pero funciona.
            {
                id_ciclo = reader.GetInt32(0);
            }
            reader.Close();
            return id_ciclo;
        }

        private void asignar_nombre_ciclo(string nif)
        {
            string nombre_ciclo = "";
            string consulta2 = "SELECT nombre from ciclo WHERE id=@id;";
            MySqlCommand comando2 = new MySqlCommand(consulta2, conexion.Conexion);
            comando2.Parameters.AddWithValue("id", buscar_ciclo(nif));
            MySqlDataReader reader2 = comando2.ExecuteReader();
            while (reader2.Read())
            {
                nombre_ciclo = reader2.GetString(0);
            }
            reader2.Close();
        }

        /// <summary>
        /// Metodo que seleciona el nombre y apellidos del profesor que pertenece al modulo selecionado y al ciclo del alumno.
        /// Y tambien asigna el nif al profesor.
        /// </summary>
        /// <returns>Retorna el nombre del profesor</returns>
        public string cargar_profesor_modulos()
        {
            
            int ciclo=buscar_ciclo();
            string ciclos ="";
            string consulta = string.Format("SELECT u.nombre,u.apellido,u.nif FROM usuario u INNER JOIN ciclo_pertenece c INNER JOIN modulo_profesor m ON m.nif_user=c.user_nif AND c.user_nif=u.nif WHERE m.modulo = '{0}' AND c.cicl = '{1}'; ", profesor.modulo,ciclo);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())//Esto deberia ser un if pero no me iba. Opte por el while auque no es lo mas optimo.
            {
                ciclos=reader.GetString(0)+" "+reader.GetString(1);
                this.nif = reader.GetString(2);//Cargamos el nif del dicho profesor por si alguna vez lo necesitamos.
            }
            reader.Close();
            return ciclos;
        }


        /// <summary>
        /// Metodo que reserva al profesor.
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="hora"></param>
        public void realizar_reserva_profesor(DateTime dia,string hora)
        {
            string nif = usuario.BuscarNIF(usuario.Email);//El nif lo buscamos directamente del usuario logueado.
            string consulta = "INSERT INTO reservar_profesor VALUES(@id,@h_re,@ocu,@id_user,@nif_profe,@dia);";//No hemos puesto ningun condicion para comprobar las horas reservadas, lo haremos mas tarde.
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("id", null);
            comando.Parameters.AddWithValue("h_re", hora);
            comando.Parameters.AddWithValue("ocu", true);//Este campo sobra.
            comando.Parameters.AddWithValue("id_user", nif);
            comando.Parameters.AddWithValue("nif_profe", this.nif);//El nif del profesor lo hemos guardado en el metodo anterior.
            comando.Parameters.AddWithValue("dia", dia.ToString("yyyy/MM/dd"));
            comando.ExecuteNonQuery();

        }

        /// <summary>
        /// Metodo que seleciona las horas ocupadas y devulve las horas libres.
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>
        public List<string> filtrar_horas_por_dias(DateTime dia)
        {
            TimeSpan a = new TimeSpan(0, 0, 0);
            List<string> hora_dia=new List<string>();
            string consulta = "SELECT hora_reserva FROM reservar_profesor WHERE dia_reserva=@dia and nif_profesor=@nif_pro order by hora_reserva asc;";
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("dia", dia.ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("nif_pro", this.nif);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                a=reader.GetTimeSpan(0);
                hora_dia.Add(a.ToString());
            }
            reader.Close();
            profesor p = new profesor();
            List<string> ho = new List<string>();
            ho = p.Lista_horas;
            for (int i = 0; i < hora_dia.Count; i++)
            {
                ho.Remove(hora_dia[i]);
            }
            return ho;
        }


        //Metodos que se ha optimizado.
        //public List<int> buscar_indice(DateTime dias)
        //{
        //    List<int> num=new List<int>();
        //    List<string> fecha = filtrar_horas_por_dias(dias);
        //    for(int i = 0; i < fecha.Count; i++)
        //    {
        //        for(int j = 0; j < lista_horas.Count; j++)
        //        {
        //            if (lista_horas[j] == fecha[i])
        //            {
        //                num.Add(j);
        //            }
        //        }
        //    }
        //    return num;
        //}


        //public List<string> horas_filtradas(List<int> ind)
        //{
        //    List<string> ho=new List<string>();
        //    profesor p=new profesor();
        //    ho = p.Lista_horas;
        //    int o = 0;
        //    for(int i=0;i< ind.Count; i++)
        //    {
        //        ho.RemoveAt(ind[i]-o);
        //        o++;
        //    }
        //    return ho;
        //}

        
        public static List<profesor> tutoriaprivada()
        {
            List<profesor> tutoria=new List<profesor>();
            string consulta = "SELECT * FROM reservar_profesor WHERE nif_profesor=@nif_pro order by hora_reserva asc, dia_reserva asc;";
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("nif_pro", usuario.BuscarNIF(usuario.Email));
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
               tutoria.Add(new profesor(reader.GetTimeSpan(1),reader.GetDateTime(5),reader.GetString(3)));
            }
            reader.Close();
            return tutoria;

        }
    }


}
