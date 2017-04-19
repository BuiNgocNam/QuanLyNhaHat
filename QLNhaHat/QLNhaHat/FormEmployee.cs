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

        

        

        private List<Seat> GetSeat()
        {
            string sql = "SELECT * FROM LoaiVe";
            return new SeatBUS().GetSeat(sql);
        }


        private void FormEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                LoadBookedSeat();
                dgvCustomer.DataSource = GetCustomer();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

 
        



     
        List<Button> ListSeat = new List<Button>();
        int intThanhTien = 0;
        private void btnA1_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button) sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    txtMaVe.Text += " " + btn.Text;
                    btn.BackColor = Color.Lime;
                    ListSeat.Add(btn);
                    
                }
                else if (btn.BackColor == Color.Violet)
                {
                    txtMaVe.Text += " " + btn.Text;
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


        ///////////////////////////
        // Hàm lấy dữ liệu khách hàng
        ///////////////////////////
        private List<Customer> GetCustomer()
        {
            string sql = "SELECT * FROM KhachHang";
            return new CustomerBUS().GetCustomer(sql);
        }


        ///////////////////////////
        // Nút thêm khách hàng
        ///////////////////////////
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


        ///////////////////////////
        // Nút sửa khách hàng
        ///////////////////////////
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



        ///////////////////////////
        // Nút tìm khách hàng
        ///////////////////////////
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {

        }


        ///////////////////////////
        // Nút xóa khách hàng
        ///////////////////////////
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


        private List<Button> LoadBookedSeat()
        {
            List<Button> bookedSeats = new List<Button>();
            {
                bookedSeats.Add(btnA1);
                bookedSeats.Add(btnA2);
                bookedSeats.Add(btnA3);
                bookedSeats.Add(btnA4);
                bookedSeats.Add(btnA5);
                bookedSeats.Add(btnA6);
                bookedSeats.Add(btnA7);
                bookedSeats.Add(btnA8);
                bookedSeats.Add(btnB1);
                bookedSeats.Add(btnB2);
                bookedSeats.Add(btnB3);
                bookedSeats.Add(btnB4);
                bookedSeats.Add(btnB5);
                bookedSeats.Add(btnB6);
                bookedSeats.Add(btnB7);
                bookedSeats.Add(btnB8);
                bookedSeats.Add(btnC1);
                bookedSeats.Add(btnC2);
                bookedSeats.Add(btnC3);
                bookedSeats.Add(btnC4);
                bookedSeats.Add(btnC5);
                bookedSeats.Add(btnC6);
                bookedSeats.Add(btnC7);
                bookedSeats.Add(btnC8);
                bookedSeats.Add(btnD1);
                bookedSeats.Add(btnD2);
                bookedSeats.Add(btnD3);
                bookedSeats.Add(btnD4);
                bookedSeats.Add(btnD5);
                bookedSeats.Add(btnD6);
                bookedSeats.Add(btnD7);
                bookedSeats.Add(btnD8);
                bookedSeats.Add(btnE1);
                bookedSeats.Add(btnE2);
                bookedSeats.Add(btnE3);
                bookedSeats.Add(btnE4);
                bookedSeats.Add(btnE5);
                bookedSeats.Add(btnE6);
                bookedSeats.Add(btnE7);
                bookedSeats.Add(btnE8);
                return bookedSeats;

                //foreach(string c in bookedSeats)
                //{
                //    foreach( string d in GetSeat())
                //}
            }
        }


        ///////////////////////////
        // Nút đặt chỗ ngồi
        ///////////////////////////
        private void btnBook_Click(object sender, EventArgs e)
        {
            string MaVe, Loai, HangGhe;
            bool TinhTrang;
            int Gia;
            foreach (Button l in ListSeat)
            {
                //Nếu ghế đó đang được chọn (màu xanh) và là ghế loại thường
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

                //Nếu ghế đó đang được chọn (màu xanh) và là ghế loại VIP
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


        ///////////////////////////
        // Nút reset thông tin đặt chỗ
        ///////////////////////////
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaVe.Text = "";
            txtTongTien.Text = "";
            foreach (Button l in ListSeat)
            {
                //Nếu ghế đó đang được chọn (màu xanh) và là ghế loại thường
                if (l.BackColor == Color.Lime && l.Text != "C1" && l.Text != "C2" && l.Text != "C3" && l.Text != "C4" && l.Text != "C5" && l.Text != "C6" && l.Text != "C7" && l.Text != "C8"
                     && l.Text != "D1" && l.Text != "D2" && l.Text != "D3" && l.Text != "D4" && l.Text != "D5" && l.Text != "D6" && l.Text != "D7" && l.Text != "D8")
                {
                    l.BackColor = Color.White;
                }
                //Nếu ghế đó đang được chọn (màu xanh) và là ghế loại VIP
                if (l.BackColor == Color.Lime && (l.Text == "C1" || l.Text == "C2" || l.Text == "C3" || l.Text == "C4" || l.Text == "C5" || l.Text == "C6" || l.Text == "C7" || l.Text == "C8"
                     || l.Text == "D1" || l.Text == "D2" || l.Text == "D3" || l.Text == "D4" || l.Text == "D5" || l.Text == "D6" || l.Text == "D7" || l.Text == "D8"))
                {
                    l.BackColor = Color.Violet;
                }
                
            }
            ListSeat = new List<Button>();
        }


        ///////////////////////////
        // Chỉ cho phép nhập ký tự số
        ///////////////////////////
        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        ///////////////////////////
        // Xử lý các nút bật TabPage
        ///////////////////////////
        private void btnSeatPage_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void btnCustomerPage_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }


        ///////////////////////////
        // Đóng form Employee
        ///////////////////////////
        private void btnCloseEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.ShowDialog();
        }


    }
}
