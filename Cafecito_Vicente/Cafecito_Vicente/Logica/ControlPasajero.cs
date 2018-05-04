using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafecito_Vicente.Datos;
using Cafecito_Vicente.BD;
using System.Data;


namespace Cafecito_Vicente.Logica
{
    class ControlPasajero
    {
        BaseDatos mbaseDatos;

        public ControlPasajero()
        {
            mbaseDatos = new BaseDatos();
            mbaseDatos.Conectar("MySQL ODBC 5.2w Driver", "localhost", "autobuses", "root", "");

        }
        public void agregarPasajero(Pasajero mPasajero)
        {
            String SQL = "insert into pasajero values ('?1', '?2','?3','?4')";
            SQL = SQL.Replace("?1", mPasajero.ID);
            SQL = SQL.Replace("?2", mPasajero.nombre);
            SQL = SQL.Replace("?3", mPasajero.apellido);
            SQL = SQL.Replace("?4",mPasajero.Asiento.ToString());
            mbaseDatos.ejecutarActualizacion(SQL);
        }
        public DataTable consultarPasajero()
        {
            String SQL = "select * from pasajero";
            DataTable ListaPasajero = mbaseDatos.ejecutarConsulta(SQL, true);
            return ListaPasajero;
        }
        public DataTable consultarPasajero(string nombre)
        {
            String SQL = "select * from pasajero where nombre=?2;";
            SQL = SQL.Replace("?2", nombre);
            DataTable ListaPasajero = mbaseDatos.ejecutarConsulta(SQL, true);
            return ListaPasajero;
        }
        public void modificarPasajero(Pasajero mPasajero)
        {
            String SQL = "update pasajero set nombre='?2',apellido='?3' where id='?1'";
            SQL = SQL.Replace("?1", mPasajero.ID);
            SQL = SQL.Replace("?2", mPasajero.nombre);
            SQL = SQL.Replace("?3", mPasajero.apellido);
            SQL = SQL.Replace("?4", mPasajero.Asiento.ToString());

        }
        public void eliminarPasajero(int ID)
        {
            String SQL = "delete from pasajero where id= '?1'";
            SQL = SQL.Replace("?1", ID.ToString());
            mbaseDatos.ejecutarActualizacion(SQL);
        }

    }
}
