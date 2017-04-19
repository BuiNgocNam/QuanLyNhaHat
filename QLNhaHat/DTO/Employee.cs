using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Employee
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public int SDT { get; set; }
        public string ChucVu { get; set; }
        public string DiaChi { get; set; }
        public int MaBoPhan { get; set; }

        public Employee(string manv, string hoten, string ngaysinh, string gioitinh, int sdt, string chucvu, string diachi, int mabophan)
        {
            MaNV = manv;
            HoTen = hoten;
            NgaySinh = ngaysinh;
            GioiTinh = gioitinh;
            SDT = sdt;
            ChucVu = chucvu;
            DiaChi = diachi;
            MaBoPhan = mabophan;
        }



    }
}
