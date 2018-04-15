using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafecito_Vicente.Datos
{
    class Pasajero
    {
        private string id;
        private String Nombre;
        private String Apellido;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public String nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public String apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        
    }
}
