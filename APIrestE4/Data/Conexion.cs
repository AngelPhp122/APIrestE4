using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace APIrestE4.Data
{
    public class Conexion
    {
        private SqlConnection conexionBD;
        
        
        private string cadenaConexion;
        
        private const string DBName = "SAIDataBase";
        private const string servidor = "SAIDataBase.mssql.somee.com";


        public void setConexionDB(SqlConnection conexionDb) {

            conexionBD = conexionDb;

        }

        public SqlConnection getConexionDB() {

            return conexionBD;
        }

        public Conexion() {

            cadenaConexion = "Data Source=" + servidor + ";" + "Initial Catalog=" + DBName + ";" + "user id=Gramirez_SQLLogin_1; pwd=dr5yknohfs";

            conexionBD = new SqlConnection (cadenaConexion);

        }

    }
}