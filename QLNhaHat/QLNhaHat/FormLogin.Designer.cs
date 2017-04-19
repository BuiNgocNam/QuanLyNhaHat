namespace QLNhaHat
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckboxHidden = new System.Windows.Forms.CheckBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtDangNhap = new System.Windows.Forms.TextBox();
            this.btnLoginESC = new System.Windows.Forms.Button();
            this.btnLoginOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "- Đăng nhập bằng tài khoản Admin để quản lý nhân sự\r\n- Đăng nhập bằng tài khoản N" +
                "hân viên để quản lý thông tin khách hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên đăng nhập:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckboxHidden
            // 
            this.ckboxHidden.AutoSize = true;
            this.ckboxHidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxHidden.Location = new System.Drawing.Point(210, 184);
            this.ckboxHidden.Name = "ckboxHidden";
            this.ckboxHidden.Size = new System.Drawing.Size(122, 19);
            this.ckboxHidden.TabIndex = 7;
            this.ckboxHidden.Text = "Hiển thị mật khẩu";
            this.ckboxHidden.UseVisualStyleBackColor = true;
            this.ckboxHidden.CheckedChanged += new System.EventHandler(this.ckboxHidden_CheckedChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(210, 154);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(215, 24);
            this.txtMatKhau.TabIndex = 6;
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangNhap.Location = new System.Drawing.Point(210, 121);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(215, 24);
            this.txtDangNhap.TabIndex = 5;
            // 
            // btnLoginESC
            // 
            this.btnLoginESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginESC.Location = new System.Drawing.Point(318, 218);
            this.btnLoginESC.Name = "btnLoginESC";
            this.btnLoginESC.Size = new System.Drawing.Size(129, 42);
            this.btnLoginESC.TabIndex = 9;
            this.btnLoginESC.Text = "Thoát";
            this.btnLoginESC.UseVisualStyleBackColor = true;
            // 
            // btnLoginOK
            // 
            this.btnLoginOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginOK.Location = new System.Drawing.Point(114, 218);
            this.btnLoginOK.Name = "btnLoginOK";
            this.btnLoginOK.Size = new System.Drawing.Size(134, 42);
            this.btnLoginOK.TabIndex = 8;
            this.btnLoginOK.Text = "Đăng Nhập";
            this.btnLoginOK.UseVisualStyleBackColor = true;
            this.btnLoginOK.Click += new System.EventHandler(this.btnLoginOK_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 288);
            this.Controls.Add(this.btnLoginESC);
            this.Controls.Add(this.btnLoginOK);
            this.Controls.Add(this.ckboxHidden);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckboxHidden;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtDangNhap;
        private System.Windows.Forms.Button btnLoginESC;
        private System.Windows.Forms.Button btnLoginOK;
    }
}