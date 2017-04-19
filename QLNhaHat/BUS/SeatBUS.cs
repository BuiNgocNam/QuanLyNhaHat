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
    public class SeatBUS
    {
        public List<Seat> GetSeat(string sql)
        {
            try
            {
                return new SeatDAO().GetSeat(sql);

                //EmployeeDAO emp = new EmployeeDAO();
                //List<Employee> list = emp.GetEmployee(sql);
                //return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Update(string MaVe, Seat seat)
        {
            try
            {
                return (new SeatDAO().Update(MaVe, seat));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int GetBookedSeat(string MaVe)
        {
            try
            {
                return (new SeatDAO().GetBookedSeat(MaVe));
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
