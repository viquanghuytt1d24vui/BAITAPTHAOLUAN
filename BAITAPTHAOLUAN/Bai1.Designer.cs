namespace BAITAPTHAOLUAN
{
    partial class Bai1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblbankinh = new System.Windows.Forms.Label();
            this.lblchuvi = new System.Windows.Forms.Label();
            this.lbldientich = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.btnlamlai = new System.Windows.Forms.Button();
            this.txtbankinh = new System.Windows.Forms.TextBox();
            this.txtchuvi = new System.Windows.Forms.TextBox();
            this.txtdientich = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TINH CHU VI VA DIEN TICH HINH TRON";
            // 
            // lblbankinh
            // 
            this.lblbankinh.AutoSize = true;
            this.lblbankinh.Location = new System.Drawing.Point(66, 126);
            this.lblbankinh.Name = "lblbankinh";
            this.lblbankinh.Size = new System.Drawing.Size(57, 16);
            this.lblbankinh.TabIndex = 0;
            this.lblbankinh.Text = "ban kinh";
            // 
            // lblchuvi
            // 
            this.lblchuvi.AutoSize = true;
            this.lblchuvi.Location = new System.Drawing.Point(66, 195);
            this.lblchuvi.Name = "lblchuvi";
            this.lblchuvi.Size = new System.Drawing.Size(41, 16);
            this.lblchuvi.TabIndex = 0;
            this.lblchuvi.Text = "chu vi";
            // 
            // lbldientich
            // 
            this.lbldientich.AutoSize = true;
            this.lbldientich.Location = new System.Drawing.Point(66, 267);
            this.lbldientich.Name = "lbldientich";
            this.lbldientich.Size = new System.Drawing.Size(56, 16);
            this.lbldientich.TabIndex = 0;
            this.lbldientich.Text = "dien tich";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(149, 348);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(116, 50);
            this.btntinh.TabIndex = 1;
            this.btntinh.Text = "tinh";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // btnlamlai
            // 
            this.btnlamlai.Location = new System.Drawing.Point(368, 348);
            this.btnlamlai.Name = "btnlamlai";
            this.btnlamlai.Size = new System.Drawing.Size(106, 50);
            this.btnlamlai.TabIndex = 2;
            this.btnlamlai.Text = "lam lai";
            this.btnlamlai.UseVisualStyleBackColor = true;
            this.btnlamlai.Click += new System.EventHandler(this.btnlamlai_Click);
            // 
            // txtbankinh
            // 
            this.txtbankinh.Location = new System.Drawing.Point(169, 126);
            this.txtbankinh.Name = "txtbankinh";
            this.txtbankinh.Size = new System.Drawing.Size(324, 22);
            this.txtbankinh.TabIndex = 3;
            // 
            // txtchuvi
            // 
            this.txtchuvi.Location = new System.Drawing.Point(169, 192);
            this.txtchuvi.Name = "txtchuvi";
            this.txtchuvi.ReadOnly = true;
            this.txtchuvi.Size = new System.Drawing.Size(324, 22);
            this.txtchuvi.TabIndex = 3;
            // 
            // txtdientich
            // 
            this.txtdientich.Location = new System.Drawing.Point(168, 267);
            this.txtdientich.Name = "txtdientich";
            this.txtdientich.ReadOnly = true;
            this.txtdientich.Size = new System.Drawing.Size(325, 22);
            this.txtdientich.TabIndex = 3;
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtdientich);
            this.Controls.Add(this.txtchuvi);
            this.Controls.Add(this.txtbankinh);
            this.Controls.Add(this.btnlamlai);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lbldientich);
            this.Controls.Add(this.lblchuvi);
            this.Controls.Add(this.lblbankinh);
            this.Controls.Add(this.label1);
            this.Name = "Bai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbankinh;
        private System.Windows.Forms.Label lblchuvi;
        private System.Windows.Forms.Label lbldientich;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Button btnlamlai;
        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.TextBox txtchuvi;
        private System.Windows.Forms.TextBox txtdientich;
    }
}

