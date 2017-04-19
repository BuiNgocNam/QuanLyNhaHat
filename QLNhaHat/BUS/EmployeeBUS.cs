using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
    public class EmployeeBUS
    {

        public int LoginSuccess(string sql, string MaNV, string MatKhau)
        {
            try
            {
                return (new EmployeeDAO().LoginSuccess(sql, MaNV, MatKhau));
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }


        public List<Employee> GetEmployee(string sql)
        {
            try
            {
                return new EmployeeDAO().GetEmployee(sql);

                //EmployeeDAO emp = new EmployeeDAO();
                //List<Employee> list = emp.GetEmployee(sql);
                //return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        

        public int Add(Employee emp)
        {
            //Kiểm tra ràng buộc tự nhiên
            if (true)
            {

            }
            try
            {
                return (new EmployeeDAO().Add(emp));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Delete(string MaNV)
        {
            try
            {
                return (new EmployeeDAO().Delete(MaNV));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public int Search(string sql)
        //{
        //    try
        //    {
        //        return (new EmployeeDAO().Search(sql));
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        public int Update(string MaNV, Employee emp)
        {
            try
            {
                return (new EmployeeDAO().Update(MaNV, emp));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        


    }
}
