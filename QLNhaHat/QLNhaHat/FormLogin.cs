using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BUS;
using DTO;

namespace QLNhaHat
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            FormDelay f = new FormDelay();
            f.ShowDialog();
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginOK_Click(object sender, EventArgs e)
        {
            string username = txtDangNhap.Text;
            string password = txtMatKhau.Text;
            string sql = "SELECT Count(*) FROM DangNhap WHERE MaNV=@MaNV AND MatKhau= @MatKhau";
            int x = new EmployeeBUS().LoginSuccess(sql, username, password);
            if (username.Length == 0 && password.Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên và Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (username.Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Username", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (username == "NV1" && password == "admin")
            {
                MessageBox.Show("Đăng Nhập Thành Công với tư cách Quản Lý", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormAdmin f = new FormAdmin();
                f.ShowDialog();
            }
            else if (username == "NV2" && password == "NV2")
            {
                MessageBox.Show("Đăng Nhập Thành Công với tư cách Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormEmployee f = new FormEmployee();
                f.ShowDialog();
            }
            //else if (x == 1)
            //{

            //    MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Hide();
            //    FormAdmin f = new FormAdmin();
            //    f.ShowDialog();
            //}
            else
                MessageBox.Show("Tên Đăng Nhập không Đúng,Vui Lòng Kiểm Tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ckboxHidden_CheckedChanged(object sender, EventArgs e)
        {
            if (ckboxHidden.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnLoginESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
