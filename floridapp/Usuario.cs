﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace floridapp
{
    internal class usuario
    {
        private string nif;
        private string correo;
        private string contraseña;
        private string nombre;
        private string apellido;
        private int tel;
        private bool profesor;
        private bool alumno;
        private bool admi;
        private bool cocina;
        private bool biblioteca;
        private static string email;
        private static int tipo;

        public usuario(string nif, string correo, string contraseña, string nombre, string apellido, int tel, bool profesor, bool alumno, bool admi, bool cocina, bool biblioteca)
        {
            this.nif = nif;
            this.correo = correo;
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tel = tel;
            this.profesor = profesor;
            this.alumno = alumno;
            this.admi = admi;
            this.cocina = cocina;
            this.biblioteca = biblioteca;
        }

        public usuario(bool profesor, bool alumno, bool admi, bool cocina, bool biblioteca)
        {
            this.profesor=profesor;
            this.alumno=alumno;
            this.admi=admi;
            this.cocina=cocina;
            this.biblioteca=biblioteca;
        }

        public usuario()
        {

        }

        public string Nif { get => nif; set => nif = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Tel { get => tel; set => tel = value; }
        public bool Profesor { get => profesor; set => profesor = value; }
        public bool Alumno { get => alumno; set => alumno = value; }
        public bool Admi { get => admi; set => admi = value; }
        public bool Cocina { get => cocina; set => cocina = value; }
        public bool Biblioteca { get => biblioteca; set => biblioteca = value; }
        public static string Email { get => email; set => email = value; }
        public static int Tipo { get => tipo; set => tipo = value; }

        static private List<usuario> tipoUsuario(string mail)
        {
            List<usuario> us=new List<usuario>();
            string search = string.Format("SELECT profesor,alumno,administrador,cocina,biblioteca FROM usuario where correo='{0}';",mail);
            MySqlCommand comando = new MySqlCommand(search, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                 us.Add(new usuario(reader.GetBoolean(0), reader.GetBoolean(1), reader.GetBoolean(2), reader.GetBoolean(3), reader.GetBoolean(4)));
            }
            reader.Close();
            return us;
        }

        static public int VerifyUser(string mail, string password)
        {
            List<usuario> user = tipoUsuario(mail);
            int tipo=0;
            string consulta="";
            if (user[0].Profesor)
            {
                tipo = 1;
            }else if (user[0].Alumno)
            {
                tipo = 2;
            }
            else if (user[0].Admi)
            {
                tipo = 3;
            }
            else if (user[0].Cocina)
            {
                tipo = 4;
            }else if (user[0].Biblioteca)
            {
                tipo=5;
            }
            else
            {
                MessageBox.Show("Error al asignar un tipo de usuario.");
            }
            switch (tipo)
            {
                case 1:
                    consulta = string.Format("SELECT correo,contraseña FROM usuario WHERE correo='{0}' and profesor=true", mail);
                    MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        if ((reader.GetString(0) == mail && reader.GetString(1) == password))
                        {
                            return 1;
                        }
                    }
                    reader.Close();
                    comando.ExecuteNonQuery();
                    break;
                    
                case 2:
                    consulta = string.Format("SELECT correo,contraseña FROM usuario WHERE correo='{0}' and alumno=true", mail);
                    MySqlCommand comando1 = new MySqlCommand(consulta, conexion.Conexion);
                    MySqlDataReader reader1 = comando1.ExecuteReader();
                    while (reader1.Read())
                    {
                        if ((reader1.GetString(0) == mail && reader1.GetString(1) == password))
                        {
                            return 2;
                        }
                    }
                    reader1.Close();
                    comando1.ExecuteNonQuery();
                    break;
                case 3:
                    consulta = string.Format("SELECT correo,contraseña FROM usuario WHERE correo='{0}' and administrador=true", mail);
                    MySqlCommand comando2 = new MySqlCommand(consulta, conexion.Conexion);
                    MySqlDataReader reader2 = comando2.ExecuteReader();
                    while (reader2.Read())
                    {
                        if ((reader2.GetString(0) == mail && reader2.GetString(1) == password))
                        {
                            return 3;
                        }
                    }
                    reader2.Close();
                    comando2.ExecuteNonQuery();
                    break;
                case 4:
                    consulta = string.Format("SELECT correo,contraseña FROM usuario WHERE correo='{0}' and cocina=true", mail);
                    MySqlCommand comando4 = new MySqlCommand(consulta, conexion.Conexion);
                    MySqlDataReader reader4 = comando4.ExecuteReader();
                    while (reader4.Read())
                    {
                        if ((reader4.GetString(0) == mail && reader4.GetString(1) == password))
                        {
                            return 4;
                        }
                    }
                    reader4.Close();
                    comando4.ExecuteNonQuery();
                    break;
                    
                case 5:
                    consulta = string.Format("SELECT correo,contraseña FROM usuario WHERE correo='{0}' and biblioteca=true", mail);
                    MySqlCommand comando3 = new MySqlCommand(consulta, conexion.Conexion);
                    MySqlDataReader reader3 = comando3.ExecuteReader();
                    while (reader3.Read())
                    {
                        if ((reader3.GetString(0) == mail && reader3.GetString(1) == password))
                        {
                            return 5;
                        }
                    }
                    reader3.Close();
                    comando3.ExecuteNonQuery();
                    break;
                default:
                    MessageBox.Show("Error al conectarse.");
                    break;
            }
            return 0;
        }

        static public bool MailExiste(string mail)
        {
            string consulta = "";
            consulta = string.Format("SELECT correo FROM usuario WHERE correo = '{0}'", mail);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }

        public static string BuscarNIF(string mail)
        {
            string nif = "";
            string consulta=string.Format("Select nif from usuario where correo='{0}';",mail);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                nif= reader.GetString(0);
            }
            reader.Close();
            return nif;
        }

        public int AgregarUsuario(usuario usu)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO usuario (nif,correo,contraseña,nombre,apellido,tel,profesor,administrador,cocina,biblioteca,alumno) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", usu.nif, usu.correo, usu.contraseña, usu.nombre, 
                usu.apellido, usu.tel, usu.profesor, usu.admi, usu.cocina, usu.biblioteca, usu.alumno);

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public int ActualizaUsuario(usuario usu)
        {
            int retorno;
            string consulta = string.Format("UPDATE usuarios SET correo='{0}',contraseña='{1}',nombre='{2}',apellido='{3}',tel='{4}',profesor={5}," +
                "administrador='{6}',cocina='{7}',biblioteca='{8}',alumno='{9}'  WHERE nif={10}", usu.correo, usu.contraseña, usu.nombre, usu.apellido, usu.tel,
                usu.profesor, usu.admi, usu.cocina, usu.biblioteca, usu.alumno, usu.nif);

            MessageBox.Show(consulta);

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<usuario> BuscarUsuario(string consulta)
        {
            List<usuario> lista = new List<usuario>();
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows) 
            {
                while (reader.Read())
                {
                    usuario user = new usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetBoolean(6),
                        reader.GetBoolean(7), reader.GetBoolean(8), reader.GetBoolean(9), reader.GetBoolean(10));
                    lista.Add(user);
                }
            }
            return lista;
        }

        public static usuario ObtenerUsuario(string nif)
        {
            usuario usu = new usuario();
            string consulta = string.Format("SELECT * FROM usuario WHERE nif={0}", nif);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                usu.nif = reader.GetString(0);
                usu.correo = reader.GetString(1);
                usu.contraseña = reader.GetString(2);
                usu.nombre = reader.GetString(3);
                usu.apellido = reader.GetString(4);
                usu.tel = reader.GetInt32(5);
                usu.profesor = reader.GetBoolean(6);
                usu.admi = reader.GetBoolean(7);
                usu.cocina = reader.GetBoolean(8);
                usu.biblioteca = reader.GetBoolean(9);
                usu.alumno = reader.GetBoolean(10);
            }
            return usu;
        }

        public static int EliminaUsuario(string nif)
        {
            int retorno;
            string consulta = string.Format("DELETE FROM usuario WHERE nif={0}", nif);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}