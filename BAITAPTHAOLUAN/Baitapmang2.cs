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
    public partial class Baitapmang2 : Form
    {
        public Baitapmang2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btntaomang_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtnhap.Text);
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
            txtdayso.Text = string.Join(", ", arr);
        }

        private void btnminmax_Click(object sender, EventArgs e)
        {
            int min, max;
            if (string.IsNullOrWhiteSpace(txtdayso.Text))
            {
                MessageBox.Show("Vui lòng tạo mảng trước khi tìm min và max.");
                return;
            }
            if(txtdayso.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mảng hợp lệ.");
                return;
            }
            if(rbtmax.Checked)
            {
                max = int.MinValue;
                string[] elements = txtdayso.Text.Split(',');
                foreach (string element in elements)
                {
                    int num = int.Parse(element.Trim());
                    if (num > max)
                    {
                        max = num;
                    }
                }
                txtketqua1.Text = "Giá trị lớn nhất: " + max.ToString();
            }
            else if (rbtmin.Checked)
            {
                min = int.MaxValue;
                string[] elements = txtdayso.Text.Split(',');
                foreach (string element in elements)
                {
                    int num = int.Parse(element.Trim());
                    if (num < min)
                    {
                        min = num;
                    }
                }
                txtketqua1.Text = "Giá trị nhỏ nhất: " + min.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm giá trị lớn nhất hoặc nhỏ nhất.");
            }
        }

        private void btnsapxep_Click(object sender, EventArgs e)
        {
            txtdayso.Text = txtdayso.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtdayso.Text))
            {
                MessageBox.Show("Vui lòng tạo mảng trước khi sắp xếp.");
                return;
            }
            if(txtdayso.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mảng hợp lệ.");
                return;
            }
            if(rbttang.Checked)
            {
                string[] elements = txtdayso.Text.Split(',');
                int[] arr = elements.Select(int.Parse).ToArray();
                Array.Sort(arr);
                txtketqua2.Text =string.Join(", ", arr);
            }
            else if (rbtgiam.Checked)
            {
                string[] elements = txtdayso.Text.Split(',');
                int[] arr = elements.Select(int.Parse).ToArray();
                Array.Sort(arr);
                Array.Reverse(arr);
                txtketqua2.Text =string.Join(", ", arr);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sắp xếp tăng dần hoặc giảm dần.");
            }
        }
    }
}
