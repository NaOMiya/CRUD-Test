using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Crud.Data
{
    
    //-----------------------------------------------------------------------------------------
    /// <summary>
    /// データベースコネクションクラス
    /// </summary>
    //-----------------------------------------------------------------------------------------
    public class DbConnection
    {

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// データベース接続
        /// </summary>
        /// <param name="sql">SQL文</param>
        /// <returns>SQLコマンド</returns>
        //-------------------------------------------------------------------------------------
        public SqlCommand Connection(string sql)
        {
            string connectionString = string.Empty;
            connectionString += "Data Source         = C32D\\LOCALHOST;";//localhost;";
            connectionString += "Initial Catalog     = SampleDB;";
            connectionString += "Integrated Security = false;";
            connectionString += "User ID             = sa;";
            connectionString += "Password            = chiiki";

            try
            {
                //データベースと接続するためにSqlDataAdapterインスタンスを生成
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connectionString;

                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = conn;
                sqlCom.CommandText = sql;
                return sqlCom;

            }
            catch (SqlException)
            {
                
            }
            throw new NotImplementedException();
        }
    }
}
