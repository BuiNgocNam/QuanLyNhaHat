using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class CustomerDAO
    {
        private DataProvider dp;
        

        public CustomerDAO()
        {
            dp = new DataProvider();
        }


        ///////////////////////////
        // Lấy danh sách KHÁCH HÀNG
        ///////////////////////////
        public List<Customer> GetCustomer(string sql)
        {
            List<Customer> list = new List<Customer>();

            string MaKH, HoTen, NgaySinh, GioiTinh, DiaChi;
            int SDT;
            dp.Connect();
            try
            {
                SqlDataReader dr = dp.ExecuteReader(sql);
                while (dr.Read())
                {
                    MaKH = dr.GetString(0);
                    HoTen = dr.GetString(1);
                    NgaySinh = dr.GetString(2);
                    GioiTinh = dr.GetString(3);
                    SDT = dr.GetInt32(4);
                    DiaChi = dr.GetString(5);
                    Customer cus = new Customer(MaKH, HoTen, NgaySinh, GioiTinh, SDT, DiaChi);
                    list.Add(cus);
                }

                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dp.Disconnect();
            }
        }


        ///////////////////////////
        // Thêm mới khách hàng
        ///////////////////////////
        public int Add(Customer cus)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaNV", cus.MaKH));
            paras.Add(new SqlParameter("@HoTen", cus.HoTen));
            paras.Add(new SqlParameter("@NgaySinh", cus.NgaySinh));
            paras.Add(new SqlParameter("@GioiTinh", cus.GioiTinh));
            paras.Add(new SqlParameter("@SDT", cus.SDT));
            paras.Add(new SqlParameter("@ChucVu", cus.DiaChi));
            try
            {
                return (dp.ExecuteNonQuery("uspAddCustomer", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        ///////////////////////////
        // Sửa thông tin khách hàng
        ///////////////////////////
        public int Update(string MaNV, Customer cus)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaNV", cus.MaKH));
            paras.Add(new SqlParameter("@HoTen", cus.HoTen));
            paras.Add(new SqlParameter("@NgaySinh", cus.NgaySinh));
            paras.Add(new SqlParameter("@GioiTinh", cus.GioiTinh));
            paras.Add(new SqlParameter("@SDT", cus.SDT));
            paras.Add(new SqlParameter("@ChucVu", cus.DiaChi));
            try
            {
                return (dp.ExecuteNonQuery("uspUpdateCustomer", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        ///////////////////////////
        // Xóa thông tin khách hàng
        ///////////////////////////
        public int Delete(string MaKH)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaKH", MaKH));
            try
            {
                return (dp.ExecuteNonQuery("uspDeleteCustomer", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        ///////////////////////////
        // Tìm kiếm thông tin khách hàng
        ///////////////////////////
        public int Search(string MaKH)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaKH", MaKH));
            try
            {
                return (dp.ExecuteNonQuery("uspSearchCustomer", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
