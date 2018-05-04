using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafecito_Vicente.BD;
using Cafecito_Vicente.Datos;
using System.Data;
namespace Cafecito_Vicente.Logica
{
    class ControlBoleto
    {
         BaseDatos mbaseDatos;

        
        public ControlBoleto()
        {
            mbaseDatos = new BaseDatos();
            mbaseDatos.Conectar("MySQL ODBC 5.2w Driver", "localhost", "autobuses", "root", "");

        }
        public void agregarBoleto(Boleto mBoleto)
        {
            String SQL = "insert into boleto values ('?1', '?2', '?3')";
            SQL = SQL.Replace("?1", mBoleto.id.ToString());
            SQL = SQL.Replace("?2", mBoleto.Precio.ToString());
            SQL = SQL.Replace("?3", mBoleto.tipo);
            
     
            mbaseDatos.ejecutarActualizacion(SQL);
        }
        public DataTable consultarBoleto()
        {
            String SQL = "select * from boleto";
            DataTable ListaBoleto = mbaseDatos.ejecutarConsulta(SQL,true);
            return ListaBoleto;
        }

        public void modificarBoleto(Boleto mBoleto)
        {
            String SQL = "update boleto set precio='?2, tipo = '?3' where id_boleto='?1'";
            SQL = SQL.Replace("?1", mBoleto.id.ToString());
            SQL = SQL.Replace("?2", mBoleto.Precio.ToString());
            SQL = SQL.Replace("?3", mBoleto.tipo);

           

        }
        public void eliminarBoleto(int ID)
        {
            String SQL = "delete from boleto where id_boleto= '?1'";
            SQL = SQL.Replace("?1", ID.ToString());
            mbaseDatos.ejecutarActualizacion(SQL);
        }

    }
    }

