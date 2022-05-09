using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrado
{
    internal class cafeteria
    {
        private int numero_mesa;
        private bool reservado;

        public cafeteria(int numero_mesa, bool reservado)
        {
            this.numero_mesa = numero_mesa;
            this.reservado = reservado;
        }

        public int Numero_mesa { get => numero_mesa; set => numero_mesa = value; }
        public bool Reservado { get => reservado; set => reservado = value; }
    }
}
