using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafecito_Vicente.Datos
{
    class Corrida
    {
        private String Origen;
        private String Destino;
        private DateTime fecha;
        private DateTime Hora;

        public String origen
        {
            get { return Origen; }
            set { Origen = value; }
        }
        public String destino
        {
            get { return Destino; }
            set { Destino = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public DateTime hora
        {
            get { return Hora; }
            set { Hora = value; }
        }
    }
}
