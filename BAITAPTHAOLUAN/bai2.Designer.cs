namespace BAITAPTHAOLUAN
{
    partial class bai2
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
            this.txtdientich = new System.Windows.Forms.TextBox();
            this.txtchieudai = new System.Windows.Forms.TextBox();
            this.btnlamlai = new System.Windows.Forms.Button();
            this.btntinh = new System.Windows.Forms.Button();
            this.lbldientich = new System.Windows.Forms.Label();
            this.lblchieudai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblchieurong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtchuvi = new System.Windows.Forms.TextBox();
            this.txtchieurong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtdientich
            // 
            this.txtdientich.Location = new System.Drawing.Point(217, 268);
            this.txtdientich.Name = "txtdientich";
            this.txtdientich.ReadOnly = true;
            this.txtdientich.Size = new System.Drawing.Size(325, 22);
            this.txtdientich.TabIndex = 10;
            // 
            // txtchieudai
            // 
            this.txtchieudai.Location = new System.Drawing.Point(218, 127);
            this.txtchieudai.Name = "txtchieudai";
            this.txtchieudai.Size = new System.Drawing.Size(324, 22);
            this.txtchieudai.TabIndex = 12;
            // 
            // btnlamlai
            // 
            this.btnlamlai.Location = new System.Drawing.Point(417, 349);
            this.btnlamlai.Name = "btnlamlai";
            this.btnlamlai.Size = new System.Drawing.Size(106, 50);
            this.btnlamlai.TabIndex = 9;
            this.btnlamlai.Text = "lam lai";
            this.btnlamlai.UseVisualStyleBackColor = true;
            this.btnlamlai.Click += new System.EventHandler(this.btnlamlai_Click);
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(198, 349);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(116, 50);
            this.btntinh.TabIndex = 8;
            this.btntinh.Text = "tinh";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // lbldientich
            // 
            this.lbldientich.AutoSize = true;
            this.lbldientich.Location = new System.Drawing.Point(115, 268);
            this.lbldientich.Name = "lbldientich";
            this.lbldientich.Size = new System.Drawing.Size(56, 16);
            this.lbldientich.TabIndex = 4;
            this.lbldientich.Text = "dien tich";
            // 
            // lblchieudai
            // 
            this.lblchieudai.AutoSize = true;
            this.lblchieudai.Location = new System.Drawing.Point(115, 127);
            this.lblchieudai.Name = "lblchieudai";
            this.lblchieudai.Size = new System.Drawing.Size(73, 16);
            this.lblchieudai.TabIndex = 6;
            this.lblchieudai.Text = "CHIEU DAI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "TINH CHU VI VA DIEN TICH HINH CHU NHAT";
            // 
            // lblchieurong
            // 
            this.lblchieurong.AutoSize = true;
            this.lblchieurong.Location = new System.Drawing.Point(115, 161);
            this.lblchieurong.Name = "lblchieurong";
            this.lblchieurong.Size = new System.Drawing.Size(69, 16);
            this.lblchieurong.TabIndex = 6;
            this.lblchieurong.Text = "chieu rong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "chu vi";
            // 
            // txtchuvi
            // 
            this.txtchuvi.Location = new System.Drawing.Point(217, 223);
            this.txtchuvi.Name = "txtchuvi";
            this.txtchuvi.ReadOnly = true;
            this.txtchuvi.Size = new System.Drawing.Size(324, 22);
            this.txtchuvi.TabIndex = 11;
            // 
            // txtchieurong
            // 
            this.txtchieurong.Location = new System.Drawing.Point(217, 161);
            this.txtchieurong.Name = "txtchieurong";
            this.txtchieurong.Size = new System.Drawing.Size(324, 22);
            this.txtchieurong.TabIndex = 12;
            // 
            // bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtdientich);
            this.Controls.Add(this.txtchuvi);
            this.Controls.Add(this.txtchieurong);
            this.Controls.Add(this.txtchieudai);
            this.Controls.Add(this.btnlamlai);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lbldientich);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblchieurong);
            this.Controls.Add(this.lblchieudai);
            this.Controls.Add(this.label1);
            this.Name = "bai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdientich;
        private System.Windows.Forms.TextBox txtchieudai;
        private System.Windows.Forms.Button btnlamlai;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label lbldientich;
        private System.Windows.Forms.Label lblchieudai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblchieurong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtchuvi;
        private System.Windows.Forms.TextBox txtchieurong;
    }
}