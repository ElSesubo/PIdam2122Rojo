using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace floridapp
{
    class Usuario
    {
        private string nif;
        private string correo;
        private string password;
        private string nombre;
        private string apellido;
        private int tel;
        private bool profesor;
        private bool administrador;
        private bool cocina;
        private bool biblioteca;

        public string Nif { get => nif; set => nif = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Password { get => password; set => password = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Tel { get => tel; set => tel = value; }
        public bool Profesor { get => profesor; set => profesor = value; }
        public bool Administrador { get => administrador; set => administrador = value; }
        public bool Cocina { get => cocina; set => cocina = value; }
        public bool Biblioteca { get => biblioteca; set => biblioteca = value; }

        public Usuario(string nif, string correo, string password, string nombre, string apellido, int tel, bool profesor, bool administrador, bool cocina, bool biblioteca)
        {
            this.nif = nif;
            this.correo = correo;
            this.password = password;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tel = tel;
            this.profesor = profesor;
            this.administrador = administrador;
            this.cocina = cocina;
            this.biblioteca = biblioteca;
        }

        public Usuario()
        {

        }
    }
}
