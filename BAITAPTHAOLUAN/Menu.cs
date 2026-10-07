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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bài1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bai1 bai1Form = new Bai1();
            bai1Form.MdiParent = this;
            bai1Form.Show();
        }

        private void bài2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bai2 bai2Form = new bai2();
            bai2Form.MdiParent = this;
            bai2Form.Show();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bai3 bai3Form = new bai3();
            bai3Form.MdiParent = this;
            bai3Form.Show();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai4 bai4Form = new Bai4();
            bai4Form.MdiParent = this;
            bai4Form.Show();

        }

        private void bài5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai5 bai5Form = new Bai5();
            bai5Form.MdiParent = this;
            bai5Form.Show();
        }

        private void bài6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai6 Bai6Form = new Bai6();
            Bai6Form.MdiParent = this;
            Bai6Form.Show();
        }

        private void bài1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Baitapvemang1 bai1Form = new Baitapvemang1();
            bai1Form.MdiParent = this;
            bai1Form.Show();
        }

        private void bài2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Baitapmang2 bai2Form = new Baitapmang2();
            bai2Form.MdiParent = this;
            bai2Form.Show();
        }
    }
}
