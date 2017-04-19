using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class SeatDAO
    {
        private DataProvider dp;

        public SeatDAO()
        {
            dp = new DataProvider();
        }

        ///////////////////////////
        // Lấy danh sách Ghế
        ///////////////////////////
        public List<Seat> GetSeat(string sql)
        {
            List<Seat> list = new List<Seat>();

            string MaVe, Loai, HangGhe;
            bool TinhTrang;
            int Gia;
            dp.Connect();
            try
            {
                SqlDataReader dr = dp.ExecuteReader(sql);
                while (dr.Read())
                {
                    MaVe = dr.GetString(0);
                    Loai = dr.GetString(1);
                    HangGhe = dr.GetString(2);
                    Gia = dr.GetInt32(3);
                    TinhTrang = dr.GetBoolean(4);
                    Seat seat = new Seat(MaVe, Loai, HangGhe, Gia, TinhTrang);
                    list.Add(seat);
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
        // Cập nhật tình trạng Ghế
        ///////////////////////////
        public int Update(string MaVe, Seat seat)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaVe", seat.MaVe));
            paras.Add(new SqlParameter("@TinhTrang", seat.TinhTrang));         
            try
            {
                return (dp.ExecuteNonQuery("uspUpdateSeat", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        ///////////////////////////
        // Lấy danh sách đặt Ghế
        ///////////////////////////
        public int GetBookedSeat(string MaVe)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaVe", MaVe));
            try
            {
                return (dp.ExecuteNonQuery("uspGetBookedSeat", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
