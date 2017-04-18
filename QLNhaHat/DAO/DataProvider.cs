using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using DTO;

namespace DAO
{
    public class DataProvider
    {
        string cnStr = "";
        SqlConnection cn;

        public DataProvider()
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cn = new SqlConnection(cnStr);
        }

        public void Connect()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Disconnect()
        {


            if (cn != null && cn.State != ConnectionState.Closed)
                cn.Close();


        }

        public SqlDataReader ExecuteReader(string sql)
        {

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                return (cmd.ExecuteReader());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //uspAddEmployee
        public int ExecuteNonQuery(string sql, CommandType type, List<SqlParameter> paras)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;
                if (paras != null)
                {
                    foreach (SqlParameter para in paras)
                    {
                        cmd.Parameters.Add(para);
                    }
                }
                cmd.ExecuteNonQuery();
                return 1; //trả ve thông tin
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Disconnect();
            }
        }

       

       


    }
}
