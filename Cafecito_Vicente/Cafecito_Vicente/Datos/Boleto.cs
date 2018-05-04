using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafecito_Vicente.Datos
{
    class Boleto
    {
        private int ID;
        private float precio;
        private string Tipo;

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public string tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }


        
    }
}
