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
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double chieuddai, chieurong, dientich, chuvi;
            if (string.IsNullOrWhiteSpace(txtchieudai.Text) || string.IsNullOrWhiteSpace(txtchieurong.Text))
            {
                MessageBox.Show("Vui lòng nhập chiều dài và chiều rộng.");
            }
            else
            {
                if (!double.TryParse(txtchieudai.Text, out chieuddai) || !double.TryParse(txtchieurong.Text, out chieurong))
                {
                    MessageBox.Show("Vui lòng nhập chiều dài và chiều rộng hợp lệ.");
                }
                else
                {
                    if (chieuddai < 0 || chieurong < 0)
                    {
                        MessageBox.Show("Chiều dài và chiều rộng không được âm.");
                        return;
                    }
                    else
                    {
                        chieuddai = double.Parse(txtchieudai.Text);
                        chieurong = double.Parse(txtchieurong.Text);
                    }
                    dientich = chieuddai * chieurong;
                    chuvi = 2 * (chieuddai + chieurong);
                    txtdientich.Text = dientich.ToString();
                    txtchuvi.Text = chuvi.ToString();
                }
            }
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txtchieudai.Clear();
            txtchieurong.Clear();
            txtdientich.Clear();
            txtchuvi.Clear();
            txtchieudai.Focus();
        }
    }
}
