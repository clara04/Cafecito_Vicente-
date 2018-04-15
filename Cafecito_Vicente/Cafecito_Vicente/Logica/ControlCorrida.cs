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
    class ControlCorrida
    {
        BaseDatos mbaseDatos;

        
        public ControlCorrida()
        {
            mbaseDatos = new BaseDatos();
            mbaseDatos.Conectar("MySQL ODBC 5.2w Driver", "localhost", "autobuses", "", "");

        }
        public void agregarCorrida(Corrida mCorrida)
        {
            String SQL = "insert into corrida values (null, '?1', '?2','?3','?4','?5')";
            SQL = SQL.Replace("?1", mCorrida.id);
            SQL = SQL.Replace("?2", mCorrida.origen);
            SQL = SQL.Replace("?3", mCorrida.destino);
            SQL = SQL.Replace("?5", mCorrida.fecha);
            SQL = SQL.Replace("?5", mCorrida.hora);

            mbaseDatos.ejecutarActualizacion(SQL);
        }
        public DataSet consultarCorrida()
        {
            String SQL = "select * from corrida";
            DataSet ListaCorrida = mbaseDatos.ejecutarConsulta(SQL);
            return ListaCorrida;
        }
        public void modificarCorrida(Corrida mCorrida)
        {
            String SQL = "update corrida set origen='?2',destino='?3', fecha='?4' , hora = '?5' where id='?1'";
            SQL = SQL.Replace("?1", mCorrida.id);
            SQL = SQL.Replace("?2", mCorrida.origen);
            SQL = SQL.Replace("?3", mCorrida.destino);
            SQL = SQL.Replace("?4", mCorrida.fecha);
            SQL = SQL.Replace("?5", mCorrida.hora);

        }
        public void eliminarCorrida(int ID)
        {
            String SQL = "delete from corrida where id= '?1'";
            SQL = SQL.Replace("?1", ID.ToString());
            mbaseDatos.ejecutarActualizacion(SQL);
        }

    }
    }

