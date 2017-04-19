using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNhaHat
{
    public partial class FormBill : Form
    {
        public FormBill(string MaVe,string MaNV, string MaKH, int TongTien)
        {
            InitializeComponent();
            lblMaVe.Text = MaVe;
            lblMaNV.Text = MaNV;
            lblMaKH.Text = MaKH;
            lblTongTien.Text = TongTien.ToString();
        }

        private void FormBill_Load(object sender, EventArgs e)
        {

        }
    }
}
