
namespace QuanLyKhachSan_DoAnWindow
{
    partial class FormInHoaDon
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
            this.txt_theomahoadon = new System.Windows.Forms.TextBox();
            this.txt_theomakhachhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_quaylai = new System.Windows.Forms.Button();
            this.txt_xuathoadon = new System.Windows.Forms.Button();
            this.txt_inhoadon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo mã hóa đơn :";
            // 
            // txt_theomahoadon
            // 
            this.txt_theomahoadon.Location = new System.Drawing.Point(180, 19);
            this.txt_theomahoadon.Name = "txt_theomahoadon";
            this.txt_theomahoadon.Size = new System.Drawing.Size(124, 20);
            this.txt_theomahoadon.TabIndex = 1;
            // 
            // txt_theomakhachhang
            // 
            this.txt_theomakhachhang.Location = new System.Drawing.Point(180, 63);
            this.txt_theomakhachhang.Name = "txt_theomakhachhang";
            this.txt_theomakhachhang.Size = new System.Drawing.Size(124, 20);
            this.txt_theomakhachhang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm mã khách hàng :";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(369, 28);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(79, 36);
            this.txt_timkiem.TabIndex = 4;
            this.txt_timkiem.Text = "Tìm kiếm";
            this.txt_timkiem.UseVisualStyleBackColor = true;
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_theomakhachhang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_theomahoadon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 95);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txt_quaylai
            // 
            this.txt_quaylai.Location = new System.Drawing.Point(473, 28);
            this.txt_quaylai.Name = "txt_quaylai";
            this.txt_quaylai.Size = new System.Drawing.Size(79, 36);
            this.txt_quaylai.TabIndex = 6;
            this.txt_quaylai.Text = "Quay lại";
            this.txt_quaylai.UseVisualStyleBackColor = true;
            this.txt_quaylai.Click += new System.EventHandler(this.txt_quaylai_Click);
            // 
            // txt_xuathoadon
            // 
            this.txt_xuathoadon.Location = new System.Drawing.Point(369, 77);
            this.txt_xuathoadon.Name = "txt_xuathoadon";
            this.txt_xuathoadon.Size = new System.Drawing.Size(79, 36);
            this.txt_xuathoadon.TabIndex = 7;
            this.txt_xuathoadon.Text = "Xuất hóa đơn";
            this.txt_xuathoadon.UseVisualStyleBackColor = true;
            this.txt_xuathoadon.Click += new System.EventHandler(this.txt_xuathoadon_Click);
            // 
            // txt_inhoadon
            // 
            this.txt_inhoadon.Location = new System.Drawing.Point(473, 81);
            this.txt_inhoadon.Name = "txt_inhoadon";
            this.txt_inhoadon.Size = new System.Drawing.Size(79, 36);
            this.txt_inhoadon.TabIndex = 8;
            this.txt_inhoadon.Text = "In hóa đơn";
            this.txt_inhoadon.UseVisualStyleBackColor = true;
            this.txt_inhoadon.Click += new System.EventHandler(this.txt_inhoadon_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_inhoadon);
            this.panel1.Controls.Add(this.txt_xuathoadon);
            this.panel1.Controls.Add(this.txt_quaylai);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txt_timkiem);
            this.panel1.Location = new System.Drawing.Point(4, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 153);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(4, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 339);
            this.panel2.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(5, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 330);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormInHoaDon";
            this.Text = "Hóa đơn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_theomahoadon;
        private System.Windows.Forms.TextBox txt_theomakhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txt_timkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txt_quaylai;
        private System.Windows.Forms.Button txt_xuathoadon;
        private System.Windows.Forms.Button txt_inhoadon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}