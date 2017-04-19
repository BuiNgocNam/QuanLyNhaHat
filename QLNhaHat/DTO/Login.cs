using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Login
    {
        public string MaNV { get; set; }
        public string MatKhau { get; set; }

        public Login(string manv, string matkhau)
        {
            MaNV = manv;
            MatKhau = matkhau;
        }
    }
}
