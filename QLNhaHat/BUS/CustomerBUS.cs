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
    public class CustomerBUS
    {

        public List<Customer> GetCustomer(string sql)
        {
            try
            {
                return new CustomerDAO().GetCustomer(sql);

                //EmployeeDAO emp = new EmployeeDAO();
                //List<Employee> list = emp.GetEmployee(sql);
                //return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Add(Customer cus)
        {
            //Kiểm tra ràng buộc tự nhiên
            if (true)
            {
                
            }
            try
            {
                return (new CustomerDAO().Add(cus));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Delete(string MaKH)
        {
            try
            {
                return (new CustomerDAO().Delete(MaKH));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Search(string MaKH)
        {
            try
            {
                return (new CustomerDAO().Search(MaKH));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Update(string MaKH, Customer cus)
        {
            try
            {
                return (new CustomerDAO().Update(MaKH, cus));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
