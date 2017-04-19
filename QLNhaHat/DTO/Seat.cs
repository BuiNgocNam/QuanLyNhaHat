using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Seat
    {
        public string MaVe { get; set; }
        public string Loai { get; set; }
        public string HangGhe { get; set; }
        public int Gia { get; set; }
        public bool TinhTrang { get; set; }

        public Seat(string mave, string loai, string hangghe, int gia, bool tinhtrang)
        {
            MaVe = mave;
            Loai = loai;
            HangGhe = hangghe;
            Gia = gia;
            TinhTrang = tinhtrang;
        }
    }
}
