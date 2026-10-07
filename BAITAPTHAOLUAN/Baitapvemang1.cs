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
    public partial class Baitapvemang1 : Form
    {
        public Baitapvemang1()
        {
            InitializeComponent();
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtnhap.Text);
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
            txtmanggoc.Text = string.Join(", ", arr);
        }

        private void btndemsole_Click(object sender, EventArgs e)
        {
            int demsole = 0;
            txtmanggoc.Text = txtmanggoc.Text.Trim();
            string[] elements = txtmanggoc.Text.Split(',');
            foreach (string element in elements)
            {
                int num = int.Parse(element.Trim());
                if (num % 2 != 0)
                {
                    demsole++;
                }
            }
            txtketqua.Text = demsole.ToString();
        }

        private void btntongle_Click(object sender, EventArgs e)
        {
            int tongsole = 0;
            txtmanggoc.Text = txtmanggoc.Text.Trim();
            string[] elements = txtmanggoc.Text.Split(',');
            foreach (string element in elements)
            {
                int num = int.Parse(element.Trim());
                if (num % 2 != 0)
                {
                    tongsole += num;
                }
            }
            txtketqua.Text = tongsole.ToString();
        }

        private void btnsapxeptang_Click(object sender, EventArgs e)
        {
            txtmanggoc.Text = txtmanggoc.Text.Trim();
            string[] elements = txtmanggoc.Text.Split(',');
            int[] arr = elements.Select(int.Parse).ToArray();
            Array.Sort(arr);
            txtketqua.Text = string.Join(", ", arr);
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            int min = int.MaxValue;
            txtmanggoc.Text = txtmanggoc.Text.Trim();
            string[] elements = txtmanggoc.Text.Split(',');
            foreach (string element in elements)
            {
                int num = int.Parse(element.Trim());
                if (num < min)
                {
                    min = num;
                }
            }
            txtketqua.Text = min.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
