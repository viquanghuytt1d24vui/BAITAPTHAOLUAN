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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double r, s, c;
            if (string.IsNullOrWhiteSpace(txtbankinh.Text))
            {
                MessageBox.Show("Vui lòng nhập bán kính.");
            }
            else
            {
                if (!double.TryParse(txtbankinh.Text, out r))
                {
                    MessageBox.Show("Vui lòng nhập bán kính hợp lệ.");
                }
                else
                {
                    if (r < 0)
                    {
                        MessageBox.Show("Bán kính không được âm.");
                        return;
                    }
                    else
                    {
                        r = double.Parse(txtbankinh.Text);
                    }
                    s = Math.PI * r * r;
                    c = 2 * Math.PI * r;
                    txtchuvi.Text = c.ToString();
                    txtdientich.Text = s.ToString();
                }
            }
        }
        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txtbankinh.Clear();
            txtchuvi.Clear();
            txtdientich.Clear();
            txtbankinh.Focus();
        }
        private void form1_Load(object sender, EventArgs e)
        {
            txtbankinh.Focus();
        }
    }
}