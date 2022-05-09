using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrado
{
    internal class biblioteca
    {
        private int id_portatil;
        private int id_pecera;
        private bool reserva_portatil;
        private bool reserva_pecera;

        public biblioteca(int id_portatil, int id_pecera, bool reserva_portatil, bool reserva_pecera)
        {
            this.id_portatil = id_portatil;
            this.id_pecera = id_pecera;
            this.reserva_portatil = reserva_portatil;
            this.reserva_pecera = reserva_pecera;
        }

        public int Id_portatil { get => id_portatil; set => id_portatil = value; }
        public int Id_pecera { get => id_pecera; set => id_pecera = value; }
        public bool Reserva_portatil { get => reserva_portatil; set => reserva_portatil = value; }
        public bool Reserva_pecera { get => reserva_pecera; set => reserva_pecera = value; }
    }
}
