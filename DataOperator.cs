using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace MyQQ
{
    class DataOperator
    {
        private static string connString = "Data Source=YOS-IK990PJPIFB;DataBase = db_MyQQ;integrated security=SSPI";
        public static SqlConnection connection = new SqlConnection(connString);

        /// <summary>
        /// 执行sql语句并返回执行结果第1行第1列数据
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>第一行第一列数据</returns>
        public int ExecSQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            int num = Convert.ToInt32(command.ExecuteScalar());//返回执行结果第一行第一列数据
            connection.Close();
            return num;
        }


        /// <summary>
        /// 执行sql语句并返回受影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>受影响行数（int）</returns>
        public int ExecSQLResult(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            int num = command.ExecuteNonQuery();//返回受影响行数
            connection.Close();
            return num;
        }

        /// <summary>
        /// 执行sql语句并返回数据集（一次性获取，可以不需要数据库保持连接）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, connection);
            DataSet dset = new DataSet();
            sqlda.Fill(dset);
            return dset;
        }


        /// <summary>
        /// 执行SQL语句，数据结果存储到SqlDataReader并返回
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>sqlDataReader</returns>
        public SqlDataReader GetDataReader(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);//执行SQL语句
            connection.Open();//打开数据库连接
            SqlDataReader dataReader = command.ExecuteReader();
            return dataReader;
        }
    }
}
