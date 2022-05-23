using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProyectoIntegrado
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
    }
}
