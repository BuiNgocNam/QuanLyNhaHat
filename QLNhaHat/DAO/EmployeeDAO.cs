using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class EmployeeDAO
    {
        private DataProvider dp;

         public EmployeeDAO()
        {
            dp = new DataProvider();
        }


        ///////////////////////////
        // Lấy đúng dữ liệu đăng nhập
        ///////////////////////////
        public int LoginSuccess(string sql, string MaNV, string MatKhau)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaNV", MaNV));
            paras.Add(new SqlParameter("@MatKhau", MatKhau));
            dp.Connect();
            try
            {
                int x = (int)dp.ExecuteScalar(sql, System.Data.CommandType.Text, paras);
                return x;
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
        // Lấy danh sách Nhân Viên
        ///////////////////////////
        public List<Employee> GetEmployee(string sql)
        {
            List<Employee> list = new List<Employee>();

            string MaNV, HoTen, NgaySinh, GioiTinh, ChucVu, QueQuan;
            int SDT, MaBoPhan;
            dp.Connect();
            try
            {
                SqlDataReader dr = dp.ExecuteReader(sql);
                while (dr.Read())
                {
                    MaNV = dr.GetString(0);
                    HoTen = dr.GetString(1);
                    NgaySinh = dr.GetString(2);
                    GioiTinh = dr.GetString(3);
                    SDT = dr.GetInt32(4);
                    ChucVu = dr.GetString(5);
                    QueQuan = dr.GetString(6);
                    MaBoPhan = dr.GetInt32(7);
                    Employee emp = new Employee(MaNV, HoTen, NgaySinh, GioiTinh, SDT, ChucVu, QueQuan, MaBoPhan);
                    list.Add(emp);
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
        // Thêm mới Nhân Viên
        ///////////////////////////
        public int Add(Employee emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaNV", emp.MaNV));
            paras.Add(new SqlParameter("@HoTen", emp.HoTen));
            paras.Add(new SqlParameter("@NgaySinh", emp.NgaySinh));
            paras.Add(new SqlParameter("@GioiTinh",emp.GioiTinh));
            paras.Add(new SqlParameter("@SDT", emp.SDT));
            paras.Add(new SqlParameter("@ChucVu", emp.ChucVu));
            paras.Add(new SqlParameter("@DiaChi", emp.DiaChi));
            paras.Add(new SqlParameter("@MaBoPhan", emp.MaBoPhan));
            try
            {
                return (dp.ExecuteNonQuery("uspAddEmployee", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        ///////////////////////////
        // Sửa thông tin Nhân Viên
        ///////////////////////////
        public int Update(string MaNV, Employee emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaNV", emp.MaNV));
            paras.Add(new SqlParameter("@HoTen", emp.HoTen));
            paras.Add(new SqlParameter("@NgaySinh", emp.NgaySinh));
            paras.Add(new SqlParameter("@GioiTinh", emp.GioiTinh));
            paras.Add(new SqlParameter("@SDT", emp.SDT));
            paras.Add(new SqlParameter("@ChucVu", emp.ChucVu));
            paras.Add(new SqlParameter("@DiaChi", emp.DiaChi));
            paras.Add(new SqlParameter("@MaBoPhan", emp.MaBoPhan));
            try
            {
                return (dp.ExecuteNonQuery("uspUpdateEmployee", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        ///////////////////////////
        // Xóa thông tin Nhân Viên
        ///////////////////////////
        public int Delete(string MaNV)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaNV", MaNV));
            try
            {
                return (dp.ExecuteNonQuery("uspDeleteEmployee", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }


        ///////////////////////////
        // Tìm kiếm thông tin Nhân Viên
        ///////////////////////////
        //public int Search(string sql)
        //{
        //    //List<SqlParameter> paras = new List<SqlParameter>();
        //    //paras.Add(new SqlParameter("@MaNV", MaNV));
        //    try
        //    {
        //        return (dp.ExecuteNonQuery(sql, System.Data.CommandType.Text,));
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}


        


    }
}
