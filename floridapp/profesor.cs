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

        //Esta clase es totalmente ajeno a las otras clases, porque la mayoria de los métodos del profesor son muy especificos por lo que no puedo hacer 2 consultas en un mismo metodo.
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
        public profesor( TimeSpan hora, DateTime dia, string nif_alumno,int cicl)
        {
            this.hora = hora;
            this.dia = dia;
            this.nif_alumno = nif_alumno;
            this.ciclo = cicl;
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
        public int buscar_ciclo()
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
        public int buscar_ciclo(string nif_a)
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
        
        /// <summary>
        /// Metodo que seleciona el nombre y apellidos del profesor que pertenece al modulo selecionado y al ciclo del alumno.
        /// Y tambien asigna el nif al profesor.
        /// </summary>
        /// <returns>Retorna el nombre del profesor</returns>
        public string cargar_profesor_modulos()
        {
            
            int ciclo=buscar_ciclo();
            string ciclos ="";
            string consulta = string.Format("SELECT u.nombre,u.apellido,u.nif FROM usuario u INNER JOIN ciclo_pertenece c INNER JOIN pertenencia_modulos p ON p.nif_prof=c.user_nif AND c.user_nif=u.nif WHERE p.modulo = '{0}' AND c.cicl = '{1}'; ", profesor.modulo,ciclo);
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
        public void realizar_reserva_profesor(DateTime dia,string hora,int cicl)
        {
            string nif = usuario.BuscarNIF(usuario.Email);//El nif lo buscamos directamente del usuario logueado.
            string consulta = "INSERT INTO reservar_profesor VALUES(@id,@h_re,@id_user,@cicl,@nif_profe,@dia);";//No hemos puesto ningun condicion para comprobar las horas reservadas, lo haremos mas tarde.
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("id", null);
            comando.Parameters.AddWithValue("h_re", hora);
            comando.Parameters.AddWithValue("cicl", cicl);
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

        
        public static List<profesor> tutoriaprivada(string nif)
        {
            List<profesor> tutoria=new List<profesor>();
            string consulta = "SELECT hora_reserva,id_user,ciclo,dia_reserva FROM reservar_profesor WHERE nif_profesor=@nif_pro;";
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("nif_pro", nif);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
               tutoria.Add(new profesor(reader.GetTimeSpan(0),reader.GetDateTime(3),reader.GetString(1),reader.GetInt32(2)));
            }
            reader.Close();
            return tutoria;

        }


        /// <summary>
        /// Este metodo es creado porque en la datagridview de profesor necesita cargar el nombre del ciclo.
        /// Le pasamos la lista de los id de los ciclos y nos devuelve una lista con los nombres de los ciclos.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static List<string> traducir_ciclos(List<int> c)
        {
            List<string> nombre_ciclo = new List<string>();
            for(int i = 0; i < c.Count; i++)
            {
                string consulta = "SELECT nombre from ciclo WHERE id=@id;";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                comando.Parameters.AddWithValue("id", c[i]);
                MySqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    nombre_ciclo.Add(reader.GetString(0));
                }
                reader.Close();
            }
            return nombre_ciclo;
        }


        /// <summary>
        /// Este metodo es creado para poder cargar los nombres de los alumnos en el datagrid view de profesor.
        /// Le pasas una lista de nifs y de devuelve una lista con los nombres y alumnos de esos nifs.
        /// </summary>
        /// <param name="us"></param>
        /// <returns></returns>
        public static List<string> traducir_nombre(List<string> us)
        {
            List<string> nombre_alumno = new List<string>();
            for (int i = 0; i < us.Count; i++)
            {
                string consulta = "SELECT nombre,apellido from usuario WHERE nif=@nif;";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                comando.Parameters.AddWithValue("nif", us[i]);
                MySqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    nombre_alumno.Add(reader.GetString(0)+" "+reader.GetString(1));
                }
                reader.Close();
            }
            return nombre_alumno;
        }


        /// <summary>
        /// Anula la tutoria previamente reservada.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="hora"></param>
        /// <param name="dia"></param>
        /// <returns>Devuelve un valor para saber si lo ha borrado o no.</returns>
        public static int anular_tutoria(string id,DateTime hora, DateTime dia)
        {
            int result = 0;
            string consulta = "DELETE FROM reservar_profesor WHERE id_user=@id_us and hora_reserva=@hora and dia_reserva=@dia;";
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("id_us", id);
            comando.Parameters.AddWithValue("hora", hora);
            comando.Parameters.AddWithValue("dia", dia);
            result= comando.ExecuteNonQuery();
            return result;
        }
        

        /// <summary>
        /// Este metodo es creado para enviar al email del profesor.
        /// </summary>
        /// <returns></returns>
        public string Email_profesor()
        {
            string email = "";
            string consulta = "SELECT correo FROM usuario WHERE nif=@nif;";
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("nif", this.Nif);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                email = reader.GetString(0);
            }
            reader.Close();
            return email;
        }
        public static string Email_alumno(string nif_a)
        {
            string email = "";
            string consulta = "SELECT correo FROM usuario WHERE nif=@nif;";
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("nif", nif_a);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                email = reader.GetString(0);
            }
            reader.Close();
            return email;
        }

        public static string Modulo_profesor()
        {
            string modulo = "";
            string consulta = "SELECT modulo FROM pertenencia_modulos WHERE nif_prof=@nif;";
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("nif", usuario.BuscarNIF(usuario.Email));
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                modulo = reader.GetString(0);
            }
            reader.Close();
            return modulo;
        }

        public static List<int> lista_ciclos(string nif_a)
        {
            List<int> list_ciclo = new List<int>();
            string consulta = string.Format("SELECT cicl from ciclo_pertenece where user_nif='{0}';", nif_a);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                list_ciclo.Add(reader.GetInt32(0));
            }
            reader.Close();
            return list_ciclo;
        }

        public static void dia_ocupado(List<int> li,DateTime dia)
        {
            string nif = usuario.BuscarNIF(usuario.Email);
            for(int i = 0; i < li.Count; i++)
            {
                string consulta = "INSERT INTO reservar_profesor VALUES(@id,@h_re,@id_user,@cicl,@nif_profe,@dia);";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                comando.Parameters.AddWithValue("id", null);
                comando.Parameters.AddWithValue("h_re", "04:00:00");
                comando.Parameters.AddWithValue("cicl", li[i]);
                comando.Parameters.AddWithValue("id_user", nif);
                comando.Parameters.AddWithValue("nif_profe", nif);
                comando.Parameters.AddWithValue("dia", dia.ToString("yyyy/MM/dd"));
                comando.ExecuteNonQuery();
            }

        }

        //public bool comprobar_dia(DateTime dia_re)
        //{
        //    string consulta = "SELECT id_user,nif_profesor FROM reservar_profesor where dia_reserva=@dia_re and nif_profesor=@nif_pro;";
        //    MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
        //    comando.Parameters.AddWithValue("dia_re", dia_re.ToString("yyyy-MM-dd"));
        //    comando.Parameters.AddWithValue("nif_pro", Nif);
        //    comando.ExecuteNonQuery();
        //    MySqlDataReader reader = comando.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        if (reader.GetString(1) == reader.GetString(0))
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
        //    reader.Close();
        //    return  true;
        //}
    }


}
