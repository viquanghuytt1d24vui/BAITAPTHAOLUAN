using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAPTHAOLUAN
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            txtxeploai.Clear();
            txtmasinhvien.Clear();
            txthovaten.Clear();
            txtlaptrinh1.Clear();
            txtlaptrinh2.Clear();
            txtmanguonmo.Clear();
            txtquantrimang.Clear();
            txtmasinhvien.Focus();
        }

        private void btntinhdiem_Click(object sender, EventArgs e)
        {
            String masv = txtmasinhvien.Text;
            char hoten = txthovaten.Text[0];
            float diemlaptrinh1, diemlaptrinh2, diemmanguonmo, diemquantrimang;
            diemlaptrinh1 = float.Parse(txtlaptrinh1.Text);
             diemlaptrinh2 = float.Parse(txtlaptrinh2.Text);
             diemmanguonmo = float.Parse(txtmanguonmo.Text);
             diemquantrimang = float.Parse(txtquantrimang.Text);
            if (String.IsNullOrWhiteSpace(txtmasinhvien.Text) || String.IsNullOrWhiteSpace(txthovaten.Text) || String.IsNullOrWhiteSpace(txtlaptrinh1.Text) || String.IsNullOrWhiteSpace(txtlaptrinh2.Text) || String.IsNullOrWhiteSpace(txtmanguonmo.Text) || String.IsNullOrWhiteSpace(txtquantrimang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if(char.IsDigit(hoten))
            {
                MessageBox.Show("Họ tên không được chứa số");
                return;
            }
            if(
                !float.TryParse(txtlaptrinh1.Text.Replace(',','.'), out diemlaptrinh1) || !float.TryParse(txtlaptrinh2.Text.Replace(',', '.'), out diemlaptrinh2) || !float.TryParse(txtmanguonmo.Text.Replace(',', '.'), out diemmanguonmo) || !float.TryParse(txtquantrimang.Text.Replace(',', '.'), out diemquantrimang))
            {
                MessageBox.Show("Điểm phải là số");
                return;
            }
            if(diemlaptrinh1 < 0 || diemlaptrinh1 > 10 || diemlaptrinh2 < 0 || diemlaptrinh2 > 10 || diemmanguonmo < 0 || diemmanguonmo > 10 || diemquantrimang < 0 || diemquantrimang > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10");
                return;
            }
            float diemtrungbinh = (diemlaptrinh1 + diemlaptrinh2 + diemmanguonmo + diemquantrimang) / 4;
            if (diemtrungbinh >= 8)
            {
                txtxeploai.Text = "Giỏi";
                txtdiemtrungbinh.Text = diemtrungbinh.ToString();
            }
            else if(diemtrungbinh >= 7 && diemtrungbinh < 8)
            {
                txtxeploai.Text = "Khá";
                txtdiemtrungbinh.Text = diemtrungbinh.ToString();
            }
            else if (diemtrungbinh >= 5 && diemtrungbinh < 7)
            {
                txtxeploai.Text = "Trung bình";
                txtdiemtrungbinh.Text = diemtrungbinh.ToString();
            }
            else
            {
                txtxeploai.Text = "Yếu";
                txtdiemtrungbinh.Text = diemtrungbinh.ToString();
            }
        }
    }
}
