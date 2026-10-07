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
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void bai3_Load(object sender, EventArgs e)
        {
               txtdiemky1.Focus();
        }

        private void lblkiemky1_Click(object sender, EventArgs e)
        {

        }

        private void lbldiemky2_Click(object sender, EventArgs e)
        {

        }

        private void lblxeploai_Click(object sender, EventArgs e)
        {

        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txtdiemky1.Text = "";
            txtdiemky2.Text = "";
            txtxeploai.Text = "";
            txtdiemky1.Focus();
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            float diemky1, diemky2, diemtrungbinh;
            if (!float.TryParse(txtdiemky1.Text, out diemky1) || !float.TryParse(txtdiemky2.Text, out diemky2))
            {
                MessageBox.Show("Vui lòng nhập điểm hợp lệ!");
                return;
            }
            if (diemky1 < 0 || diemky1 > 10 || diemky2 < 0 || diemky2 > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!");
                return;
            }
            diemtrungbinh = (diemky1 + diemky2) / 2;
            if (diemtrungbinh >= 8)
            {
                txtxeploai.Text = "Giỏi";
            }
            else if (diemtrungbinh >= 6.5)
            {
                txtxeploai.Text = "Khá";
            }
            else if (diemtrungbinh >= 5)
            {
                txtxeploai.Text = "Trung bình";
            }
            else
            {
                txtxeploai.Text = "Yếu";
            }
        }
       
    }
}
