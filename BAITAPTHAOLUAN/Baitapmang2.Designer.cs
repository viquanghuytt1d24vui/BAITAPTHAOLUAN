namespace BAITAPTHAOLUAN
{
    partial class Baitapmang2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnhap = new System.Windows.Forms.Label();
            this.lbldayso = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.txtdayso = new System.Windows.Forms.TextBox();
            this.txtketqua1 = new System.Windows.Forms.TextBox();
            this.txtketqua2 = new System.Windows.Forms.TextBox();
            this.btntaomang = new System.Windows.Forms.Button();
            this.btnminmax = new System.Windows.Forms.Button();
            this.btnsapxep = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.rbtmax = new System.Windows.Forms.RadioButton();
            this.rbtmin = new System.Windows.Forms.RadioButton();
            this.rbttang = new System.Windows.Forms.RadioButton();
            this.rbtgiam = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnhap
            // 
            this.lblnhap.AutoSize = true;
            this.lblnhap.Location = new System.Drawing.Point(55, 58);
            this.lblnhap.Name = "lblnhap";
            this.lblnhap.Size = new System.Drawing.Size(53, 16);
            this.lblnhap.TabIndex = 0;
            this.lblnhap.Text = "Nhap N";
            this.lblnhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbldayso
            // 
            this.lbldayso.AutoSize = true;
            this.lbldayso.Location = new System.Drawing.Point(55, 113);
            this.lbldayso.Name = "lbldayso";
            this.lbldayso.Size = new System.Drawing.Size(106, 16);
            this.lbldayso.TabIndex = 0;
            this.lbldayso.Text = "day so vua nhap";
            this.lbldayso.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtmin);
            this.groupBox1.Controls.Add(this.rbtmax);
            this.groupBox1.Location = new System.Drawing.Point(58, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tim_min_max";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtgiam);
            this.groupBox2.Controls.Add(this.rbttang);
            this.groupBox2.Location = new System.Drawing.Point(58, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sap xep";
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(287, 58);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(208, 22);
            this.txtnhap.TabIndex = 3;
            // 
            // txtdayso
            // 
            this.txtdayso.Location = new System.Drawing.Point(287, 113);
            this.txtdayso.Name = "txtdayso";
            this.txtdayso.Size = new System.Drawing.Size(208, 22);
            this.txtdayso.TabIndex = 3;
            // 
            // txtketqua1
            // 
            this.txtketqua1.Location = new System.Drawing.Point(287, 155);
            this.txtketqua1.Multiline = true;
            this.txtketqua1.Name = "txtketqua1";
            this.txtketqua1.Size = new System.Drawing.Size(208, 100);
            this.txtketqua1.TabIndex = 3;
            // 
            // txtketqua2
            // 
            this.txtketqua2.Location = new System.Drawing.Point(287, 284);
            this.txtketqua2.Multiline = true;
            this.txtketqua2.Name = "txtketqua2";
            this.txtketqua2.Size = new System.Drawing.Size(208, 100);
            this.txtketqua2.TabIndex = 3;
            // 
            // btntaomang
            // 
            this.btntaomang.Location = new System.Drawing.Point(576, 111);
            this.btntaomang.Name = "btntaomang";
            this.btntaomang.Size = new System.Drawing.Size(121, 39);
            this.btntaomang.TabIndex = 4;
            this.btntaomang.Text = "Tao mang";
            this.btntaomang.UseVisualStyleBackColor = true;
            this.btntaomang.Click += new System.EventHandler(this.btntaomang_Click);
            // 
            // btnminmax
            // 
            this.btnminmax.Location = new System.Drawing.Point(576, 169);
            this.btnminmax.Name = "btnminmax";
            this.btnminmax.Size = new System.Drawing.Size(121, 39);
            this.btnminmax.TabIndex = 5;
            this.btnminmax.Text = "Tim min max";
            this.btnminmax.UseVisualStyleBackColor = true;
            this.btnminmax.Click += new System.EventHandler(this.btnminmax_Click);
            // 
            // btnsapxep
            // 
            this.btnsapxep.Location = new System.Drawing.Point(576, 235);
            this.btnsapxep.Name = "btnsapxep";
            this.btnsapxep.Size = new System.Drawing.Size(121, 39);
            this.btnsapxep.TabIndex = 6;
            this.btnsapxep.Text = "Sap xep";
            this.btnsapxep.UseVisualStyleBackColor = true;
            this.btnsapxep.Click += new System.EventHandler(this.btnsapxep_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(576, 284);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(121, 39);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // rbtmax
            // 
            this.rbtmax.AutoSize = true;
            this.rbtmax.Checked = true;
            this.rbtmax.Location = new System.Drawing.Point(26, 28);
            this.rbtmax.Name = "rbtmax";
            this.rbtmax.Size = new System.Drawing.Size(53, 20);
            this.rbtmax.TabIndex = 0;
            this.rbtmax.TabStop = true;
            this.rbtmax.Text = "Max";
            this.rbtmax.UseVisualStyleBackColor = true;
            // 
            // rbtmin
            // 
            this.rbtmin.AutoSize = true;
            this.rbtmin.Location = new System.Drawing.Point(26, 74);
            this.rbtmin.Name = "rbtmin";
            this.rbtmin.Size = new System.Drawing.Size(49, 20);
            this.rbtmin.TabIndex = 1;
            this.rbtmin.Text = "Min";
            this.rbtmin.UseVisualStyleBackColor = true;
            // 
            // rbttang
            // 
            this.rbttang.AutoSize = true;
            this.rbttang.Checked = true;
            this.rbttang.Location = new System.Drawing.Point(26, 33);
            this.rbttang.Name = "rbttang";
            this.rbttang.Size = new System.Drawing.Size(60, 20);
            this.rbttang.TabIndex = 0;
            this.rbttang.TabStop = true;
            this.rbttang.Text = "Tang";
            this.rbttang.UseVisualStyleBackColor = true;
            // 
            // rbtgiam
            // 
            this.rbtgiam.AutoSize = true;
            this.rbtgiam.Location = new System.Drawing.Point(26, 66);
            this.rbtgiam.Name = "rbtgiam";
            this.rbtgiam.Size = new System.Drawing.Size(60, 20);
            this.rbtgiam.TabIndex = 1;
            this.rbtgiam.Text = "Giam";
            this.rbtgiam.UseVisualStyleBackColor = true;
            // 
            // Baitapmang2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnsapxep);
            this.Controls.Add(this.btnminmax);
            this.Controls.Add(this.btntaomang);
            this.Controls.Add(this.txtketqua2);
            this.Controls.Add(this.txtketqua1);
            this.Controls.Add(this.txtdayso);
            this.Controls.Add(this.txtnhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbldayso);
            this.Controls.Add(this.lblnhap);
            this.Name = "Baitapmang2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baitapmang2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnhap;
        private System.Windows.Forms.Label lbldayso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.TextBox txtdayso;
        private System.Windows.Forms.TextBox txtketqua1;
        private System.Windows.Forms.TextBox txtketqua2;
        private System.Windows.Forms.Button btntaomang;
        private System.Windows.Forms.Button btnminmax;
        private System.Windows.Forms.Button btnsapxep;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.RadioButton rbtmin;
        private System.Windows.Forms.RadioButton rbtmax;
        private System.Windows.Forms.RadioButton rbtgiam;
        private System.Windows.Forms.RadioButton rbttang;
    }
}