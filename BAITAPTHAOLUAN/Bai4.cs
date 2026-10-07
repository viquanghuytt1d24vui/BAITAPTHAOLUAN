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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void lblchisocuoi_Click(object sender, EventArgs e)
        {

        }

        private void lblchisodau_Click(object sender, EventArgs e)
        {

        }

        private void lbltinhtien_Click(object sender, EventArgs e)
        {

        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txtchisocuoi.Text = ""; 
            txtchisodau.Text = ""; 
            txttinhtien.Text = "";
            txtchisodau.Focus();
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            double chisodau, chisocuoi, tinhtien,kw;
            if(String.IsNullOrWhiteSpace(txtchisodau.Text) || String.IsNullOrWhiteSpace(txtchisocuoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ chỉ số điện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(txtchisodau.Text, out chisodau) || !double.TryParse(txtchisocuoi.Text, out chisocuoi))
            {
                MessageBox.Show("Vui lòng nhập chỉ số điện hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            chisodau = double.Parse(txtchisodau.Text);
            chisocuoi = double.Parse(txtchisocuoi.Text);
            if (chisocuoi < chisodau)
            {
                MessageBox.Show("Chỉ số cuối không được nhỏ hơn chỉ số đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (chisodau < 0 || chisocuoi < 0)
            {
                MessageBox.Show("Chỉ số điện không được âm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            kw = chisocuoi - chisodau;
            if (kw <= 100 && kw > 0)
            {
                tinhtien = kw * 500;
            }
            else if (kw > 100&& kw <=250)
            {
                tinhtien = 100 * 500 + (kw - 100) * 600;
            }
            else if (kw > 250 && kw <= 300)
            {
                tinhtien = 100 * 500 + 150 * 600 + (kw - 250) * 800;
            }
            else
                tinhtien = 100 * 500 + 150 * 600 + 50 * 800 + (kw - 300) * 1000;
            txttinhtien.Text = tinhtien.ToString();
        }

        private void txttinhtien_TextChanged(object sender, EventArgs e)
        {
            txttinhtien.ReadOnly = true;
        }
    }
}
