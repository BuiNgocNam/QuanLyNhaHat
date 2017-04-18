using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Customer
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public int SDT { get; set; }
        public string DiaChi { get; set; }

        public Customer(string manv, string hoten, string ngaysinh, string gioitinh,
            int sdt, string diachi)
        {
            MaKH = manv;
            HoTen = hoten;
            NgaySinh = ngaysinh;
            GioiTinh = gioitinh;
            SDT = sdt;
            DiaChi = diachi;
        }
    }
}
