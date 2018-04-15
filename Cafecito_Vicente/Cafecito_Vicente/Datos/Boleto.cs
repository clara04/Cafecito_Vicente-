using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafecito_Vicente.Datos
{
    class Boleto
    {
        private float precio;
        private string ID;
        private string Tipo;

        public string tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string id
        {
            get { return ID; }
            set { ID = value; }
        }
    }
}
