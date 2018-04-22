using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;



namespace Cafecito_Vicente.BD

{
    class BaseDatos
    {
        OdbcConnection ConexionMYSQL;
        public void Conectar(String controlador, String servidor, String basedatos, String User, String Password)
    {
        ConexionMYSQL = new OdbcConnection("Driver={"+controlador+"}; SERVER="+servidor+"; DataBase="+basedatos+";UID="+User+";PWD="+Password+";");
        ConexionMYSQL.Open(); 
    }
        public DataSet ejecutarConsulta(String SQL)
        {
            OdbcDataAdapter adaptadorDatos = new OdbcDataAdapter(SQL, ConexionMYSQL);
            DataSet resultado = new DataSet();

            adaptadorDatos.Fill(resultado);
            return resultado;
        }
        public void ejecutarActualizacion(String SQL)
        {
            OdbcCommand comando = new OdbcCommand(SQL, ConexionMYSQL);
            comando.ExecuteNonQuery();
        }
        public void Desconectar()
        {
            ConexionMYSQL.Close();
        }
        
    }
}
