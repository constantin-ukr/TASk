using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Common;

namespace Provider
{
    public class Provider
    {
        #region Private Fields
        private static IDbCommand _idbCommand = null;
        private static IDbConnection _idbConnection = null;
        private DbParameter _dbParameter = null;
        #endregion

        #region Public Settings
        public static IDbCommand DbCommand
        {
            get
            {
                if (_idbCommand != null)
                    return _idbCommand;
                return null;
            }
            private set { _idbCommand = value; }
        }

        public static IDbConnection DbConnection
        {
            get
            {
                if (_idbConnection != null)
                    return _idbConnection;
                return null;
            }
            private set { _idbConnection = value; }
        }

        /*public DbParameter DbParameter
        {
            get
            {
                if (_dbParameter != null)
                    return _dbParameter;
                return null;
            }
            private set { this._dbParameter = value; }
        }*/
        #endregion

        public Provider()
        {           
            this.OnInit(Setting.GetProviderName());
        }

        private void OnInit(string providerName)
        {
            if (providerName == "System.Data.SqlClient")
            {
                DbCommand = new SqlCommand();
                DbConnection = new SqlConnection(Setting.ConnectionString);
                //DbParameter = new SqlParameter();
            }
            else if (providerName == "System.Data.Odbc")
            {
                DbCommand = new OdbcCommand();
                DbConnection = new OdbcConnection(Setting.ConnectionString);
                //DbParameter = new OdbcParameter();
            }
            else if (providerName == "System.Data.OleDb")
            {
                DbCommand = new OleDbCommand();
                DbConnection = new OleDbConnection(Setting.ConnectionString);
                //DbParameter = new OleDbParameter();
            }
        }


    }
}
