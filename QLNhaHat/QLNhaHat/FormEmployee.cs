using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DTO;
using BUS;

namespace QLNhaHat
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        List<string> LoadBookedSeat()
        {
            List<string> bookedSeats = new List<string>();
            bookedSeats.Add(btnA1.Text);
            bookedSeats.Add(btnA2.Text);
            bookedSeats.Add(btnA3.Text);
            bookedSeats.Add(btnA4.Text);
            bookedSeats.Add(btnA5.Text);
            bookedSeats.Add(btnA6.Text);
            bookedSeats.Add(btnA7.Text);
            bookedSeats.Add(btnA8.Text);
            bookedSeats.Add(btnB1.Text);
            bookedSeats.Add(btnB2.Text);
            bookedSeats.Add(btnB3.Text);
            bookedSeats.Add(btnB4.Text);
            bookedSeats.Add(btnB5.Text);
            bookedSeats.Add(btnB6.Text);
            bookedSeats.Add(btnB7.Text);
            bookedSeats.Add(btnB8.Text);
            bookedSeats.Add(btnC1.Text);
            bookedSeats.Add(btnC2.Text);
            bookedSeats.Add(btnC3.Text);
            bookedSeats.Add(btnC4.Text);
            bookedSeats.Add(btnC5.Text);
            bookedSeats.Add(btnC6.Text);
            bookedSeats.Add(btnC7.Text);
            bookedSeats.Add(btnC8.Text);
            bookedSeats.Add(btnD1.Text);
            bookedSeats.Add(btnD2.Text);
            bookedSeats.Add(btnD3.Text);
            bookedSeats.Add(btnD4.Text);
            bookedSeats.Add(btnD5.Text);
            bookedSeats.Add(btnD6.Text);
            bookedSeats.Add(btnD7.Text);
            bookedSeats.Add(btnD8.Text);
            bookedSeats.Add(btnE1.Text);
            bookedSeats.Add(btnE2.Text);
            bookedSeats.Add(btnE3.Text);
            bookedSeats.Add(btnE4.Text);
            bookedSeats.Add(btnE5.Text);
            bookedSeats.Add(btnE6.Text);
            bookedSeats.Add(btnE7.Text);
            bookedSeats.Add(btnE8.Text);
            return bookedSeats;
        }

        private List<Seat> GetSeat()
        {
            string sql = "SELECT * FROM LoaiVe";
            return new SeatBUS().GetSeat(sql);
        }
 
        //private void compare()
        //{
        //    Button btn = (Button) sender; 
        //}




        List<Button> ListSeat = new List<Button>();
        int intThanhTien = 0;
        private void btnA1_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Lime;
                    ListSeat.Add(btn);
                    
                }
                else if (btn.BackColor == Color.Violet)
                {
                    btn.BackColor = Color.Lime;
                    ListSeat.Add(btn);
                    
                }
                else if (btn.BackColor != Color.White && btn.Text!="C1" && btn.Text!="C2" && btn.Text!="C3" && btn.Text!="C4" && btn.Text!="C5" && btn.Text!="C6" && btn.Text!="C7" && btn.Text!="C8"
                     && btn.Text!="D1" && btn.Text!="D2" && btn.Text!="D3" && btn.Text!="D4" && btn.Text!="D5" && btn.Text!="D6" && btn.Text!="D7" && btn.Text!="D8")
                {
                    btn.BackColor = Color.White;
                    ListSeat.Remove(btn);
                    
                }
                else 
                {
                    btn.BackColor = Color.Violet;
                    ListSeat.Remove(btn);
                    
                }
            }
            else
            {
                MessageBox.Show("Vị trí ghế này đã được đặt !");
            }
        }


        private void btnBook_Click(object sender, EventArgs e)
        {
            string MaVe, Loai, HangGhe; 
            bool TinhTrang;
            int Gia;
            foreach (Button l in ListSeat)
            {
                if (l.BackColor == Color.Lime && l.Text != "C1" && l.Text != "C2" && l.Text != "C3" && l.Text != "C4" && l.Text != "C5" && l.Text != "C6" && l.Text != "C7" && l.Text != "C8"
                     && l.Text != "D1" && l.Text != "D2" && l.Text != "D3" && l.Text != "D4" && l.Text != "D5" && l.Text != "D6" && l.Text != "D7" && l.Text != "D8")
                {
                    l.BackColor = Color.Yellow;
                    intThanhTien += 50000;
                    MaVe = l.Text.Trim();
                    Loai = "Thường";
                    HangGhe = l.Text[0].ToString();
                    Gia = 50000;
                    TinhTrang = true;
                    Seat seat = new Seat(MaVe,Loai,HangGhe,Gia,TinhTrang);
                    try
                    {
                        int i = new SeatBUS().Update(MaVe, seat);
                        /////////////////dgvEmployee.DataSource = GetEmployee();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }

                if (l.BackColor == Color.Lime && (l.Text == "C1" || l.Text == "C2" || l.Text == "C3" || l.Text == "C4" || l.Text == "C5" || l.Text == "C6" || l.Text == "C7" || l.Text == "C8"
                     || l.Text == "D1" || l.Text == "D2" || l.Text == "D3" || l.Text == "D4" || l.Text == "D5" || l.Text == "D6" || l.Text == "D7" || l.Text == "D8"))
                {
                    l.BackColor = Color.Yellow;
                    intThanhTien += 100000;
                    MaVe = l.Text.Trim();
                    Loai = "VIP";
                    HangGhe = l.Text[0].ToString();
                    Gia = 100000;
                    TinhTrang = true;
                    Seat seat = new Seat(MaVe, Loai, HangGhe, Gia, TinhTrang);
                    try
                    {
                        int i = new SeatBUS().Update(MaVe, seat);
                        /////////////////dgvEmployee.DataSource = GetEmployee();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }             
            }
            txtTongTien.Text = intThanhTien.ToString();
            intThanhTien = 0;
            ListSeat = new List<Button>();
        }

        //List<Label> DanhSachChon = new List<Label>();
        //int intThanhTien = 0;
        //private void label2_Click(object sender, EventArgs e)
        //{
        //    Label lbl = (Label)sender;
        //    //neu label khac mau vang
        //    if (lbl.BackColor != Color.Yellow)
        //    {
        //        //neu label la mau trang
        //        if (lbl.BackColor == Color.White)
        //        {
        //            //chuyen label mau trang thanh mau xanh
        //            lbl.BackColor = Color.Blue;
        //            DanhSachChon.Add(lbl);
        //        }
        //        else//nguoc lai label mau xanh
        //        {
        //            //chuyen sang mau trang
        //            lbl.BackColor = Color.White;
        //            DanhSachChon.Remove(lbl);
        //        }
        //    }
        //    else//label mau vang
        //    {
        //        //thang bao co nguoi chon roi
        //        MessageBox.Show("Bàn này có người chọn rồi");
        //    }
        //}
        //private void btnChon_Click(object sender, EventArgs e)
        //{
        //    foreach (Label l in DanhSachChon)
        //    {
        //        l.BackColor = Color.Yellow;
        //        intThanhTien += 100;
        //    }
        //    lblThanhTien.Text = intThanhTien.ToString();
        //    intThanhTien = 0;
        //    DanhSachChon = new List<Label>();
        //}
        //private void btnHuy_Click(object sender, EventArgs e)
        //{
        //    foreach (Label l in DanhSachChon)
        //    {
        //        l.BackColor = Color.White;
        //    }
        //    lblThanhTien.Text = "";
        //    DanhSachChon = new List<Label>();
        //}


        private List<Customer> GetCustomer()
        {
            string sql = "SELECT * FROM KhachHang";
            return new CustomerBUS().GetCustomer(sql);
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (object c in ListSeat)
                {

                }


                dgvCustomer.DataSource = GetCustomer();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string MaKH, HoTen, NgaySinh, GioiTinh, DiaChi;
            int SDT;

            MaKH = txtMaKH.Text.Trim();
            HoTen = txtHoTenKH.Text.Trim();
            NgaySinh = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            if (radNamKH.Checked)
            {
                GioiTinh = "Nam";
            }
            else
            {
                GioiTinh = "Nữ";
            }
            SDT = int.Parse(txtSdtKH.Text.Trim());
            DiaChi = txtDiaChiKH.Text.Trim();
           


            Customer cus = new Customer(MaKH, HoTen, NgaySinh, GioiTinh, SDT, DiaChi);
            try
            {


                int i = new CustomerBUS().Add(cus);
                dgvCustomer.DataSource = GetCustomer();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string MaKH, HoTen, NgaySinh, GioiTinh, DiaChi;
            int SDT;

            MaKH = txtMaKH.Text.Trim();
            HoTen = txtHoTenKH.Text.Trim();
            NgaySinh = dateTimePicker1.Value.Date.ToString();
            if (radNamKH.Checked)
            {
                GioiTinh = "Nam";
            }
            else
            {
                GioiTinh = "Nữ";
            }
            SDT = int.Parse(txtSdtKH.Text.Trim());
            DiaChi = txtDiaChiKH.Text.Trim();

            Customer cus = new Customer(MaKH, HoTen, NgaySinh, GioiTinh, SDT, DiaChi);

            try
            {
                int i = new CustomerBUS().Update(MaKH, cus);
                dgvCustomer.DataSource = GetCustomer();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


   

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH2.Text.Trim();

            try
            {
                int i = new CustomerBUS().Delete(MaKH);
                dgvCustomer.DataSource = GetCustomer();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCloseEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
    }
}
