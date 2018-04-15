using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafecito_Vicente.Datos
{
    class Corrida
    {
        private string ID;
        private String Origen;
        private String Destino;
        private String Fecha;
        private String Hora;

        public string id
        {
            get { return ID; }
            set { ID = value; }
        }
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
        public String fecha
        {
            get { return Fecha; }
            set { Fecha = value; }
        }
        public String hora
        {
            get { return Hora; }
            set { Hora = value; }
        }
    }
}
