using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace floridapp
{
    class Ciclo
    {
        private int id;
        private string nombre;
        private int curso;
        private string clase;
        private TimeSpan horario;
        private string presencialidad;
        private string nifusu;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Curso { get => curso; set => curso = value; }
        public string Clase { get => clase; set => clase = value; }
        public TimeSpan Horario { get => horario; set => horario = value; }
        public string Presencialidad { get => presencialidad; set => presencialidad = value; }
        public string Nifusu { get => nifusu; set => nifusu = value; }

        public Ciclo(int id, string nombre, int curso, string clase, TimeSpan horario, string presencialidad, string nifusu)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Curso = curso;
            this.Clase = clase;
            this.Horario = horario;
            this.Presencialidad = presencialidad;
            this.Nifusu = nifusu;
        }

        public Ciclo()
        {

        }
    }
}
