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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char tenkhach = txttenkhach.Text[0];
            double chisomoi = double.Parse(txtchisomoi.Text);
            double chisocu = double.Parse(txtchisocu.Text);
            double kw=chisocu - chisomoi;
            double thanhtien = 0;
            double thueVAT=1;
            double tongtien =0;
            if(String.IsNullOrWhiteSpace(txttenkhach.Text) || String.IsNullOrWhiteSpace(txtchisocu.Text) || String.IsNullOrWhiteSpace(txtchisomoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if(chisocu < chisomoi)
            {
                MessageBox.Show("Chỉ số mới phải lớn hơn chỉ số cũ");
                return;
            }
            if(!double.TryParse(txtchisocu.Text, out chisocu) || !double.TryParse(txtchisomoi.Text, out chisomoi))
            {
                MessageBox.Show("Chỉ số phải là số");
                return;
            }
            if(char.IsDigit(tenkhach))
            {
                MessageBox.Show("Tên khách hàng không được chứa số");
                return;
            }
            if(String.IsNullOrWhiteSpace(txttenkhach.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống");
                return;
            }
            if(rbtcanhan.Checked)
            {
                thanhtien = kw * 5000;
                thueVAT = thanhtien * 0.1;
                tongtien = thanhtien + thueVAT;
            }
            else if (rbtcoquan.Checked)
            {
                thanhtien = kw * 6000;
                thueVAT = thanhtien * 0.1;
                tongtien = thanhtien + thueVAT;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại khách hàng");
                return;
            }
            txtkw.Text = kw.ToString();
            txtthanhtien.Text = thanhtien.ToString();
            txtthue.Text = thueVAT.ToString();
            txttongcong.Text = tongtien.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void Bai5_Load(object sender, EventArgs e)
        {
            cb1.Items.Add("A01");
            cb1.Items.Add("A02");
            cb1.Items.Add("A03");
            cb1.SelectedIndex = 0;
        }

        private void txttenkhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            txtthanhtien.Clear();
            txtthue.Clear();
            txttongcong.Clear();
            txtchisocu.Clear();
            txtchisomoi.Clear();
            txttenkhach.Clear();
            txtkw.Clear();
            txttenkhach.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
