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
    public partial class FormAdmin : Form
    {
       
        string pathImg;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void Init()
        {
            pathImg = Application.StartupPath + @"\img\";
            label1.Text = "Bạn đang đăng nhập với tư cách Admin";
        }

        ///////////////////////////
        // Form Load
        ///////////////////////////
        private void FormEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                Init();
                dgvEmployee.DataSource = GetEmployee();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        ///////////////////////////
        // Hàm lấy dữ liệu nhân viên
        ///////////////////////////
        private List<Employee> GetEmployee()
        {
            string sql = "SELECT * FROM NhanVien";
            return new EmployeeBUS().GetEmployee(sql);
        }


        ///////////////////////////
        // Nút thêm nhân viên
        ///////////////////////////
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string MaNV, HoTen, GioiTinh, ChucVu, QueQuan;
            string NgaySinh;
            int SDT, MaBoPhan;

            MaNV = Convert.ToString("NV" + txtMaNV.Text.Trim());
            HoTen = txtHoTenNV.Text.Trim();
            NgaySinh = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            if (radNamNV.Checked)
            {
                GioiTinh = "Nam";
            }
            else
            {
                GioiTinh = "Nữ";
            }
            SDT = int.Parse(txtSdtNV.Text.Trim());
            ChucVu = txtChucVuNV.Text.Trim();
            QueQuan = txtDiaChiNV.Text.Trim();
            MaBoPhan = int.Parse(txtMaBoPhanNV.Text.Trim());

            Employee emp = new Employee(MaNV, HoTen, NgaySinh, GioiTinh, SDT, ChucVu, QueQuan, MaBoPhan);
            try
            {


                int i = new EmployeeBUS().Add(emp);
                dgvEmployee.DataSource = GetEmployee();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        ///////////////////////////
        // Nút sửa thông tin nhân viên
        ///////////////////////////
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            string MaNV, HoTen, GioiTinh, ChucVu, DiaChi;
            string NgaySinh;
            int SDT, MaBoPhan;

            MaNV = txtMaNV.Text.Trim();
            HoTen = txtHoTenNV.Text.Trim();
            NgaySinh = dateTimePicker1.Value.Date.ToString();
            if (radNamNV.Checked)
            {
                GioiTinh = "Nam";
            }
            else
            {
                GioiTinh = "Nữ";
            }
            SDT = int.Parse(txtSdtNV.Text.Trim());
            ChucVu = txtChucVuNV.Text.Trim();
            DiaChi = txtDiaChiNV.Text.Trim();
            MaBoPhan = int.Parse(txtMaBoPhanNV.Text.Trim());

            Employee emp = new Employee(MaNV, HoTen,NgaySinh,GioiTinh,SDT, ChucVu, DiaChi , MaBoPhan);

            try
            {
                int i = new EmployeeBUS().Update(MaNV, emp);
                dgvEmployee.DataSource = GetEmployee();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        ///////////////////////////
        // Nút tìm nhân viên
        ///////////////////////////
        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {         
           try
            {
                string MaNV = txtMaNV2.Text.Trim();
                //int i = new EmployeeBUS().Search(MaNV);
                string sql = "SELECT * FROM NhanVien WHERE MaNV = " + MaNV ;
                ////BindingSource bs = new BindingSource();
                ////bs.DataSource = dgvEmployee.DataSource;
                ////bs.Filter = MaNV + "like '%" + MaNV + "%'";
                
                ////dgvEmployee.DataSource = bs;
                //dgvEmployee.DataSource = GetEmployee1(sql, MaNV);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        ///////////////////////////
        // Nút xóa nhân viên
        ///////////////////////////
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV2.Text.Trim();

            try
            {
                int i = new EmployeeBUS().Delete(MaNV);
                dgvEmployee.DataSource = GetEmployee();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        ///////////////////////////
        // Chỉ cho phép nhập ký tự số
        ///////////////////////////
        private void txtSdtNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
      
        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        ///////////////////////////
        // Xử lý nút bật qua các TabPage
        ///////////////////////////
        private void btnEmployeePage_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void btnChartPage_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }


        ///////////////////////////
        // Đóng form Admin
        ///////////////////////////
        private void btnCloseAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.ShowDialog();
        }

       

    }
}
